# Etl.Net

|  | [![Build status](https://ci.appveyor.com/api/projects/status/sqjh6f6cwadxfoou/branch/master?svg=true)](https://ci.appveyor.com/project/paillave/etl-net) |
|-|-|
| Etl.Net | [![NuGet](https://img.shields.io/nuget/v/Etl.Net.svg)](https://www.nuget.org/packages/Etl.Net) [![NuGet](https://img.shields.io/nuget/dt/Etl.Net.svg)](https://www.nuget.org/packages/Etl.Net) |
| Etl.Net.EntityFrameworkCore | [![NuGet](https://img.shields.io/nuget/v/Etl.Net.EntityFrameworkCore.svg)](https://www.nuget.org/packages/Etl.Net.EntityFrameworkCore) [![NuGet](https://img.shields.io/nuget/dt/Etl.Net.EntityFrameworkCore.svg)](https://www.nuget.org/packages/Etl.Net.EntityFrameworkCore) |
| Etl.Net.TextFile | [![NuGet](https://img.shields.io/nuget/v/Etl.Net.TextFile.svg)](https://www.nuget.org/packages/Etl.Net.TextFile) [![NuGet](https://img.shields.io/nuget/dt/Etl.Net.TextFile.svg)](https://www.nuget.org/packages/Etl.Net.TextFile) |
| Etl.Net.ExcelFile | [![NuGet](https://img.shields.io/nuget/v/Etl.Net.ExcelFile.svg)](https://www.nuget.org/packages/Etl.Net.ExcelFile) [![NuGet](https://img.shields.io/nuget/dt/Etl.Net.ExcelFile.svg)](https://www.nuget.org/packages/Etl.Net.ExcelFile) |
| Etl.Net.ExecutionPlan | [![NuGet](https://img.shields.io/nuget/v/Etl.Net.ExecutionPlan.svg)](https://www.nuget.org/packages/Etl.Net.ExecutionPlan) [![NuGet](https://img.shields.io/nuget/dt/Etl.Net.ExecutionPlan.svg)](https://www.nuget.org/packages/Etl.Net.ExecutionPlan) |



Implementation of a multi platform reactive ETL for .net standard 2.0 working with a similar principle than SSIS, but that is used in the same way than Linq. 
The reactive approach for the implementation of this engine ensures parallelized multi streams, high performances and low memory foot print even with million rows to process.

## Developement status

**:construction: This library is still under development, don't use it on production environment yet as its api structure is subject for changes.:construction:**

The first alpha release is expected once it starts to be a decent candidate to replace SSIS for common use cases.

## ETL features

| Name | Type | Done |
| ----- | ----- | ----- |
| Select | Transformation | :heavy_check_mark: |
| Where | Transformation | :heavy_check_mark: |
| Sort | Transformation | :heavy_check_mark: |
| Left Join | Transformation | :heavy_check_mark: |
| Lookup | Transformation | :heavy_check_mark: |
| Union | Transformation | :heavy_check_mark: |
| Skip | Transformation | :heavy_check_mark: |
| Top | Transformation | :heavy_check_mark: |
| Distinct | Transformation | :heavy_check_mark: |
| Pivot | Transformation | :heavy_check_mark: |
| Unpivot | Transformation | :heavy_check_mark: |
| Aggregate | Transformation | :heavy_check_mark: |
| Cross Apply | Transformation | :heavy_check_mark: |
| Ensure Sorted | Transformation | :heavy_check_mark: |
| Ensure Keyed | Transformation | :heavy_check_mark: |
| Script | Transformation | :heavy_check_mark: |
| Select keeping sorted | Transformation | :construction: |
| Left join keeping sorted | Transformation | :construction: |
| Lookup keeping sorted | Transformation | :construction: |
| List folder files | Data source | :heavy_check_mark: |
| Read csv file | Data source | :heavy_check_mark: |
| Read very large xml file | Data source | :construction: |
| Read excel file | Data source | :heavy_check_mark: |
| Write csv file | Data destination | :heavy_check_mark: |
| Write excel file | Data destinaton | :heavy_check_mark: |
| Read from Entity framework core | Data source | :heavy_check_mark: |
| Write to Entity framework core | Data destination | :heavy_check_mark: |
| Read from Entity framework | Data source | :construction: |
| Write to Entity framework | Data destination | :construction: |
| Read from MongoDb | Data source | :construction: |
| Write to MongoDb | Data destination | :construction: |
| MongoDb upsert | Data destination | :construction: |
| Entity framework core upsert | Data destination | :heavy_check_mark: |
| Entity framework upsert | Data destination | :construction: |
| SQL Server bulk load | Data destination | :heavy_check_mark: |
| Read from sql server command | Data source | :construction: |
| Write to sql server command | Data destination | :construction: |
| List files from FTP | Data source | :construction: |
| List file from SFTP | Data source | :construction: |
| Read files from FTP | Data source | :construction: |
| Read file from SFTP | Data source | :construction: |
| Write files to FTP | Data destination | :construction: |
| Write file to SFTP | Data destination | :construction: |
| Read data from REST service | Data source | :construction: |
| Write data to REST service | Data destination | :construction: |
| Keep section | Transformation | :construction: |
| Ignore section | Transformation | :construction: |
| Run subprocess | Transformation | :construction: |

*Follow the status in the issue section*

*New requests are very welcome in the issue section*

## Runtime features

| Name | Done |
| ----- | ----- |
| Trace issued data by each node | :heavy_check_mark: |
| Trace any error | :heavy_check_mark: |
| Stop the entire process whenever an error is raised | :heavy_check_mark: |
| Trace statistic result of each node at the end of the process | :heavy_check_mark: |
| Trace time that is spent in each node at the end of the process | :construction: |
| Publish a Job as a REST web service in web api core | :construction: |
| Execute a job using reference to native .net core configuration | :construction: |
| Execute any ETL process on traces to filter and save them | :heavy_check_mark: |
| Show graphic to represent the process as a directed graph | :heavy_check_mark: |
| Show graphic to represent the process as a sankey graph | :heavy_check_mark: |
| Show graphic to represent process execution statistics as a directed graph | :heavy_check_mark: |
| Show graphic to represent process execution statistics as a sankey graph | :heavy_check_mark: |
| Show realtime process execution statistics as a directed graph | :construction: |
| Show realtime process execution statistics as a sankey graph | :construction: |
| Web portal to host job definitions and manage their executions | :construction: |
| Power shell command tool to execute a job | :construction: |
| Visual studio code addon to view the process as a directed graph whenever the job definition class file is saved | :construction: |
| Visual studio code addon to view the process as a sankey graph whenever the job definition class file is saved | :construction: |
| Raise a warning on the risky node when a performance issue or a bad practice is detected given statistics | :construction: |
| Interprets a T-SQL-like language script to build a job definition on the fly and run it | :construction: |

*New requests are very welcome in the issue section*

## Simple Quickstart :suspect:

```csharp
using Paillave.Etl;
using System;
using System.IO;
using Paillave.Etl.Core;
using Paillave.Etl.TextFile.Core;
using Paillave.Etl.Core.Streams;

namespace SimpleQuickstart
{
    public class SimpleConfig
    {
        public string InputFilePath { get; set; }
        public string OutputFilePath { get; set; }
    }

    public class SimpleInputFileRow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryCode { get; set; }
    }

    public class CategoryStatisticFileRow
    {
        public string CategoryCode { get; set; }
        public int Count { get; set; }
    }

    public class SimpleQuickstartJob : IStreamProcessDefinition<SimpleConfig>
    {
        public string Name => "Simple quickstart";

        public void DefineProcess(IStream<SimpleConfig> rootStream)
        {
            var outputFileS = rootStream.Select("open output file", i => new StreamWriter(i.OutputFilePath));
            rootStream
                .CrossApplyTextFile("read input file", new FileDefinition<SimpleInputFileRow>()
                    .MapColumnToProperty("#", i => i.Id)
                    .MapColumnToProperty("Label", i => i.Name)
                    .MapColumnToProperty("Category", i => i.CategoryCode)
                    .IsColumnSeparated('\t'), i => i.InputFilePath)
                .ToAction("Write input file to console", i => Console.WriteLine($"{i.Id}-{i.Name}-{i.CategoryCode}"))
                .Pivot("group and count", i => i.CategoryCode, i => new { Count = AggregationOperators.Count() })
                .Select("create output row", i => new CategoryStatisticFileRow { CategoryCode = i.Key, Count = i.Aggregation.Count })
                .Sort("sort output values", i => new { i.CategoryCode })
                .ToTextFile("write to text file", outputFileS, new FileDefinition<CategoryStatisticFileRow>());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var testFilesDirectory = @"XXXXXXXXXXXX\Etl.Net\src\TestFiles";

            new StreamProcessRunner<SimpleQuickstartJob, SimpleConfig>().ExecuteAsync(new SimpleConfig
            {
                InputFilePath = Path.Combine(testFilesDirectory, "simpleinputfile.csv"),
                OutputFilePath = Path.Combine(testFilesDirectory, "simpleoutputfile.csv")
            }, null).Wait();
            Console.WriteLine("Press a key...");
            Console.ReadKey();
        }
    }
}
```

## Complex Quickstart :feelsgood:

### Create configuration type

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ComplexQuickstart.StreamTypes
{
    public class MyConfig
    {
        public string InputFolderPath { get; set; }
        public string InputFilesSearchPattern { get; set; }
        public string TypeFilePath { get; set; }
        public string DestinationFilePath { get; internal set; }
        public string CategoryDestinationFilePath { get; internal set; }
    }
}
```

### Create input and output stream structures
```csharp
using System;
using System.Globalization;
using Paillave.Etl.TextFile.Core;

namespace ComplexQuickstart.StreamTypes
{
    public class InputFileRow
    {
        public int Id { get; set; }
        public DateTime Col1 { get; set; }
        public decimal Col2 { get; set; }
        public int Col3 { get; set; }
        public string Col4 { get; set; }
        public int TypeId { get; set; }
        public string FileName { get; set; }
    }

    public class InputFileRowMapper : FileDefinition<InputFileRow>
    {
        public InputFileRowMapper()
        {
            CultureInfo ci = CultureInfo.CreateSpecificCulture("en-GB");
            ci.DateTimeFormat.FullDateTimePattern = "yyyy-MM-dd HH:mm:ss";
            ci.DateTimeFormat.LongDatePattern = "yyyy-MM-dd";
            ci.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";

            ci.DateTimeFormat.FullDateTimePattern = "yyyy-MM-dd HH:mm:ss";
            ci.DateTimeFormat.LongDatePattern = "yyyy-MM-dd";
            ci.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";

            ci.NumberFormat.NumberDecimalSeparator = ",";
            ci.NumberFormat.CurrencyDecimalSeparator = ",";
            ci.NumberFormat.PercentDecimalSeparator = ",";

            this.WithCultureInfo(ci);
            this.MapColumnToProperty("#", i => i.Id);
            this.MapColumnToProperty("DateTime", i => i.Col1);
            this.MapColumnToProperty("Value", i => i.Col2);
            this.MapColumnToProperty("Rank", i => i.Col3);
            this.MapColumnToProperty("Comment", i => i.Col4);
            this.MapColumnToProperty("TypeId", i => i.TypeId);
            this.IsColumnSeparated('\t');
        }
    }
}
```
```csharp
using System.Globalization;
using Paillave.Etl.TextFile.Core;

namespace ComplexQuickstart.StreamTypes
{
    public class TypeFileRow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string FileName { get; set; }
    }

    public class TypeFileRowMapper : FileDefinition<TypeFileRow>
    {
        public TypeFileRowMapper()
        {
            CultureInfo ci = CultureInfo.CreateSpecificCulture("en-GB");
            ci.DateTimeFormat.FullDateTimePattern = "yyyy-MM-dd HH:mm:ss";
            ci.DateTimeFormat.LongDatePattern = "yyyy-MM-dd";
            ci.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";

            ci.DateTimeFormat.FullDateTimePattern = "yyyy-MM-dd HH:mm:ss";
            ci.DateTimeFormat.LongDatePattern = "yyyy-MM-dd";
            ci.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";

            ci.NumberFormat.NumberDecimalSeparator = ",";
            ci.NumberFormat.CurrencyDecimalSeparator = ",";
            ci.NumberFormat.PercentDecimalSeparator = ",";

            this.WithCultureInfo(ci);
            this.MapColumnToProperty("#", i => i.Id);
            this.MapColumnToProperty("Label", i => i.Name);
            this.MapColumnToProperty("Category", i => i.Category);
            this.IsColumnSeparated('\t');
        }
    }
}
```
```csharp

using Paillave.Etl.TextFile.Core;

namespace ComplexQuickstart.StreamTypes
{
    public class OutputFileRow
    {
        public string FileName { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class OutputFileRowMapper : FileDefinition<OutputFileRow>
    {
        public OutputFileRowMapper()
        {
            this.MapColumnToProperty("Id", i => i.Id);
            this.MapColumnToProperty("Name", i => i.Name);
            this.MapColumnToProperty("FileName", i => i.FileName);
            this.IsColumnSeparated(',');
        }
    }
}
```
```csharp

using Paillave.Etl.TextFile.Core;

namespace ComplexQuickstart.StreamTypes
{
    public class OutputCategoryRow
    {
        public string Category { get; set; }
        public int TotalAmount { get; set; }
        public int AmountOfEntries { get; set; }
    }
    public class OutputCategoryRowMapper : FileDefinition<OutputCategoryRow>
    {
        public OutputCategoryRowMapper()
        {
            this.MapColumnToProperty("Category", i => i.Category);
            this.MapColumnToProperty("Nb", i => i.AmountOfEntries);
            this.MapColumnToProperty("Tot", i => i.TotalAmount);
            this.IsColumnSeparated(',');
        }
    }
}
```
### Define the ETL job
```csharp
using ComplexQuickstart.StreamTypes;
using System.IO;
using Paillave.Etl;
using Paillave.Etl.Core.Streams;
using System;

namespace ComplexQuickstart.Jobs
{
    public class ComplexQuickstartJob : IStreamProcessDefinition<MyConfig>
    {
        public string Name => "import file";

        public void DefineProcess(IStream<MyConfig> rootStream)
        {
            var outputFileResourceS = rootStream.Select("open output file", i => new StreamWriter(i.DestinationFilePath));
            var outputCategoryResourceS = rootStream.Select("open output category file", i => new StreamWriter(i.CategoryDestinationFilePath));

            var parsedLineS = rootStream
                .CrossApplyFolderFiles("get folder files", i => i.InputFolderPath, i => i.InputFilesSearchPattern)
                .CrossApplyTextFile("parse input file", new InputFileRowMapper(), (i, p) => { p.FileName = i; return p; });

            var parsedTypeLineS = rootStream
                .Select("get input file type path", i => i.TypeFilePath)
                .CrossApplyTextFile("parse type input file", new TypeFileRowMapper());

            var joinedLineS = parsedLineS
                .Lookup("join types to file", parsedTypeLineS, i => i.TypeId, i => i.Id, (l, r) => new { l.Id, r.Name, l.FileName, r.Category });

            var categoryStatistics = joinedLineS
                .Pivot("create statistic for categories", i => i.Category, i => new { Count = AggregationOperators.Count(), Total = AggregationOperators.Sum(i.Id) })
                .Select("create output category data", i => new OutputCategoryRow { Category = i.Key, AmountOfEntries = i.Aggregation.Count, TotalAmount = i.Aggregation.Total })
                .ToTextFile("write category statistics to file", outputCategoryResourceS, new OutputCategoryRowMapper());

            joinedLineS.Select("create output data", i => new OutputFileRow { Id = i.Id, Name = i.Name, FileName = i.FileName })
                .ToTextFile("write to output file", outputFileResourceS, new OutputFileRowMapper())
                .ToAction("write to console", i => Console.WriteLine($"{i.FileName}:{i.Id}-{i.Name}"));
        }
    }
}
```
### Execute the ETL job
```csharp
using Paillave.Etl;
using System.IO;
using Paillave.Etl.Core.Streams;
using System;
using Paillave.Etl.TextFile.Core;
using ComplexQuickstart.Jobs;
using ComplexQuickstart.StreamTypes;
using Paillave.Etl.Core;

namespace ComplexQuickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            var runner = new StreamProcessRunner<ComplexQuickstartJob, MyConfig>();
            runner.GetDefinitionStructure().OpenEstimatedExecutionPlanVisNetwork();
            StreamProcessDefinition<TraceEvent> traceStreamProcessDefinition = new StreamProcessDefinition<TraceEvent>(traceStream => traceStream.ToAction("logs to console", Console.WriteLine));
            var testFilesDirectory = @"XXXXXXXXXXXXXXXX\Etl.Net\src\TestFiles";
            var task = runner.ExecuteAsync(new MyConfig
            {
                InputFolderPath = Path.Combine(testFilesDirectory, @"."),
                InputFilesSearchPattern = "testin.*.csv",
                TypeFilePath = Path.Combine(testFilesDirectory, @"ref - Copy.csv"),
                DestinationFilePath = Path.Combine(testFilesDirectory, @"outfile.csv"),
                CategoryDestinationFilePath = Path.Combine(testFilesDirectory, @"categoryStats.csv")
            }, traceStreamProcessDefinition);
            task.Result.OpenActualExecutionPlanD3Sankey();

            Console.WriteLine("Done");
            Console.WriteLine("Press a key...");
            Console.ReadKey();
        }
    }
}
```
This program first shows the estimated execution plan:

![Estimated execution plan](./docs/EstimatedExecutionPlan.PNG "Estimated execution plan")

Then it shows the actual execution with statistics when hovering streams, and input and outputs when hovering nodes:
![Actual execution plan](./docs/ActualExecutionPlan.PNG "Actual execution plan")

## Documentation

**:construction: Documentation will be done once all essential features and bugs are solved.**
