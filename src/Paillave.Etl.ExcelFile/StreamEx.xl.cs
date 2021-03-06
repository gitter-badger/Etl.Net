﻿using Paillave.Etl.Core.Streams;
using Paillave.Etl.ExcelFile.Core;
using Paillave.Etl.ExcelFile.StreamNodes;
using Paillave.Etl.ExcelFile.ValuesProviders;
using System;
using System.IO;
using SystemIO = System.IO;

namespace Paillave.Etl
{
    public static class StreamExXl
    {
        #region CrossApplyExcelSheets
        public static IStream<ExcelSheetSelection> CrossApplyExcelSheets<TIn>(this IStream<TIn> stream, string name, Func<TIn, string> getExcelFilePath)
        {
            return stream.CrossApply(name, new ExcelSheetsValuesProvider<TIn>(new ExcelSheetsValuesProviderArgs<TIn>
            {
                DataStreamSelector = i => File.OpenRead(getExcelFilePath(i)),
                NoParallelisation = false
            }), i => i, (i, j) => i);
        }
        public static IStream<ExcelSheetSelection> CrossApplyExcelSheets(this IStream<string> stream, string name)
        {
            return stream.CrossApply(name, new ExcelSheetsValuesProvider<string>(new ExcelSheetsValuesProviderArgs<string>
            {
                DataStreamSelector = i => File.OpenRead(i),
                NoParallelisation = false
            }), i => i, (i, j) => i);
        }
        public static IStream<ExcelSheetSelection> CrossApplyExcelSheets(this IStream<Stream> stream, string name)
        {
            return stream.CrossApply(name, new ExcelSheetsValuesProvider<Stream>(new ExcelSheetsValuesProviderArgs<Stream>
            {
                DataStreamSelector = i => i,
                NoParallelisation = false
            }), i => i, (i, j) => i);
        }
        public static IStream<TOut> CrossApplyExcelSheets<TIn, TOut>(this IStream<TIn> stream, string name, Func<TIn, string> getExcelFilePath, Func<ExcelSheetSelection, TIn, TOut> selector)
        {
            return stream.CrossApply(name, new ExcelSheetsValuesProvider<TIn>(new ExcelSheetsValuesProviderArgs<TIn>
            {
                DataStreamSelector = i => File.OpenRead(getExcelFilePath(i)),
                NoParallelisation = false
            }), i => i, selector);
        }
        public static IStream<TOut> CrossApplyExcelSheets<TOut>(this IStream<string> stream, string name, Func<ExcelSheetSelection, string, TOut> selector)
        {
            return stream.CrossApply(name, new ExcelSheetsValuesProvider<string>(new ExcelSheetsValuesProviderArgs<string>
            {
                DataStreamSelector = i => File.OpenRead(i),
                NoParallelisation = false
            }), i => i, selector);
        }
        #endregion

        #region CrossApplyExcelRows
        public static IStream<TOut> CrossApplyExcelRows<TParsed, TOut>(this IStream<ExcelSheetSelection> stream, string name, ExcelFileDefinition<TParsed> mapping, Func<TParsed, ExcelSheetSelection, TOut> selector) where TParsed : new()
        {
            return stream.CrossApply(name, new ExcelRowsValuesProvider<TParsed>(new ExcelRowsValuesProviderArgs<TParsed>
            {
                Mapping = mapping,
                NoParallelisation = false
            }), i => i, selector);
        }
        public static IStream<TOut> CrossApplyExcelRows<TIn, TParsed, TOut>(this IStream<TIn> stream, string name, ExcelFileDefinition<TParsed> mapping, Func<TIn, ExcelSheetSelection> sheetSelection, Func<TParsed, TIn, TOut> selector) where TParsed : new()
        {
            return stream.CrossApply(name, new ExcelRowsValuesProvider<TParsed>(new ExcelRowsValuesProviderArgs<TParsed>
            {
                Mapping = mapping,
                NoParallelisation = false
            }), sheetSelection, selector);
        }
        public static IStream<TParsed> CrossApplyExcelRows<TIn, TParsed>(this IStream<TIn> stream, string name, ExcelFileDefinition<TParsed> mapping, Func<TIn, ExcelSheetSelection> sheetSelection) where TParsed : new()
        {
            return stream.CrossApply(name, new ExcelRowsValuesProvider<TParsed>(new ExcelRowsValuesProviderArgs<TParsed>
            {
                Mapping = mapping,
                NoParallelisation = false
            }), sheetSelection, (i, o) => i);
        }
        public static IStream<TParsed> CrossApplyExcelRows<TParsed>(this IStream<ExcelSheetSelection> stream, string name, ExcelFileDefinition<TParsed> mapping) where TParsed : new()
        {
            return stream.CrossApply(name, new ExcelRowsValuesProvider<TParsed>(new ExcelRowsValuesProviderArgs<TParsed>
            {
                Mapping = mapping,
                NoParallelisation = false
            }), i => i, (i, s) => i);
        }
        #endregion

        #region ToExcelFile
        //public static IStream<TIn> ToExcelFile<TIn>(this IStream<TIn> stream, string name, IStream<SystemIO.StreamWriter> resourceStream, ExcelFileDefinition<TIn> mapping) where TIn : new()
        //{
        //    return new ToExcelFileStreamNode<TIn, IStream<TIn>>(name, new ToExcelFileArgs<TIn, IStream<TIn>>
        //    {
        //        MainStream = stream,
        //        Mapping = mapping,
        //        TargetStream = resourceStream
        //    }).Output;
        //}
        //public static ISortedStream<TIn, TKey> ToExcelFile<TIn, TKey>(this ISortedStream<TIn, TKey> stream, string name, IStream<SystemIO.StreamWriter> resourceStream, ExcelFileDefinition<TIn> mapping) where TIn : new()
        //{
        //    return new ToExcelFileStreamNode<TIn, ISortedStream<TIn, TKey>>(name, new ToExcelFileArgs<TIn, ISortedStream<TIn, TKey>>
        //    {
        //        MainStream = stream,
        //        Mapping = mapping,
        //        TargetStream = resourceStream
        //    }).Output;
        //}
        //public static IKeyedStream<TIn, TKey> ToExcelFile<TIn, TKey>(this IKeyedStream<TIn, TKey> stream, string name, IStream<SystemIO.StreamWriter> resourceStream, ExcelFileDefinition<TIn> mapping) where TIn : new()
        //{
        //    return new ToExcelFileStreamNode<TIn, IKeyedStream<TIn, TKey>>(name, new ToExcelFileArgs<TIn, IKeyedStream<TIn, TKey>>
        //    {
        //        MainStream = stream,
        //        Mapping = mapping,
        //        TargetStream = resourceStream
        //    }).Output;
        //}
        public static IStream<TIn> ToExcelFile<TIn>(this IStream<TIn> stream, string name, IStream<Stream> resourceStream)
        {
            return new ToExcelFileStreamNode<TIn, IStream<TIn>>(name, new ToExcelFileArgs<TIn, IStream<TIn>>
            {
                MainStream = stream,
                TargetStream = resourceStream
            }).Output;
        }
        public static ISortedStream<TIn, TKey> ToExcelFile<TIn, TKey>(this ISortedStream<TIn, TKey> stream, string name, IStream<Stream> resourceStream)
        {
            return new ToExcelFileStreamNode<TIn, ISortedStream<TIn, TKey>>(name, new ToExcelFileArgs<TIn, ISortedStream<TIn, TKey>>
            {
                MainStream = stream,
                TargetStream = resourceStream
            }).Output;
        }
        public static IKeyedStream<TIn, TKey> ToExcelFile<TIn, TKey>(this IKeyedStream<TIn, TKey> stream, string name, IStream<Stream> resourceStream)
        {
            return new ToExcelFileStreamNode<TIn, IKeyedStream<TIn, TKey>>(name, new ToExcelFileArgs<TIn, IKeyedStream<TIn, TKey>>
            {
                MainStream = stream,
                TargetStream = resourceStream
            }).Output;
        }
        #endregion
    }
}
