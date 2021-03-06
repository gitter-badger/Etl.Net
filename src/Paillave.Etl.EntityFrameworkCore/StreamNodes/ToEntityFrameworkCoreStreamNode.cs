﻿using Microsoft.EntityFrameworkCore;
using Paillave.Etl.Core;
using Paillave.Etl.Core.Streams;
using Paillave.Etl.Reactive.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Paillave.Etl.Reactive.Operators;
using System.Linq;
using EFCore.BulkExtensions;

namespace Paillave.Etl.EntityFrameworkCore.StreamNodes
{
    public class ToEntityFrameworkCoreArgs<TIn, TCtx, TStream>
        where TIn : class
        where TStream : IStream<TIn>
        where TCtx : DbContext
    {
        public TStream SourceStream { get; set; }
        public IStream<TCtx> DbContextStream { get; set; }
        public int BatchSize { get; set; } = 1000;
        public BulkLoadMode BulkLoadMode { get; set; } = BulkLoadMode.InsertOnly;
    }
    public enum BulkLoadMode
    {
        None,
        InsertOnly,
        Upsert
    }
    public class ToEntityFrameworkCoreStreamNode<TIn, TCtx, TStream> : StreamNodeBase<TIn, TStream, ToEntityFrameworkCoreArgs<TIn, TCtx, TStream>>
        where TIn : class
        where TStream : IStream<TIn>
        where TCtx : DbContext
    {
        public override bool IsAwaitable => true;
        public ToEntityFrameworkCoreStreamNode(string name, ToEntityFrameworkCoreArgs<TIn, TCtx, TStream> args) : base(name, args)
        {
        }

        protected override TStream CreateOutputStream(ToEntityFrameworkCoreArgs<TIn, TCtx, TStream> args)
        {
            var dbContextStream = args.DbContextStream.Observable.First();
            var ret = args.SourceStream.Observable
                .Chunk(args.BatchSize)
                .CombineWithLatest(dbContextStream, (i, c) => new { Context = c, Items = i }, true)
                .Do(i => ProcessBatch(i.Items.ToList(), i.Context, args.BulkLoadMode))
                .FlatMap(i => PushObservable.FromEnumerable(i.Items));
            return base.CreateMatchingStream(ret, args.SourceStream);
        }
        public void ProcessBatch(List<TIn> items, TCtx dbContext, BulkLoadMode bulkLoadMode)
        {
            switch (bulkLoadMode)
            {
                case BulkLoadMode.None:
                    items.ForEach(i => dbContext.Add(i));
                    dbContext.SaveChanges(); //DO NOT SET IT ASYNC HERE. The point is to retrieve the Id in case of automatic key.
                    break;
                case BulkLoadMode.InsertOnly:
                    dbContext.BulkInsert(items, new BulkConfig { PreserveInsertOrder = true, SetOutputIdentity = true, BatchSize = items.Count });
                    break;
                case BulkLoadMode.Upsert:
                    dbContext.BulkInsertOrUpdate(items, new BulkConfig { PreserveInsertOrder = true, SetOutputIdentity = true, BatchSize = items.Count });
                    break;
                default:
                    break;
            }
        }
    }
}
