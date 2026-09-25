using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Assigment_4
{
    [MemoryDiagnoser]
    public class StringBenchmark
    {
        // بيانت افتراضية للاختبار
        private static readonly string[] sessionNames = { "C# Basics", "Arrays", "Functions", "Date and Time", "Exception Handling" };
        private static readonly DateTime[] sessionDates = {
            new DateTime(2026, 9, 10, 18, 0, 0),
            new DateTime(2026, 9, 13, 18, 0, 0),
            new DateTime(2026, 9, 17, 18, 0, 0),
            new DateTime(2026, 9, 20, 18, 0, 0),
            new DateTime(2026, 9, 24, 18, 0, 0)
        };
        private static readonly int[] sessionDurations = { 180, 240, 180, 240, 180 };

        [Params(100, 1000, 10000)]
        public int Iterations;

        [Benchmark]
        public string StringConcatenation()
        {
            string result = "";
            for (int i = 0; i < Iterations; i++)
            {
                int index = i % sessionNames.Length;
                result += $"{sessionNames[index]} - {sessionDates[index].ToString("dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture)} - {sessionDurations[index]} minutes\n";
            }
            return result;
        }

        
        [Benchmark]
        public string StringBuilderConcatenation()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Iterations; i++)
            {
                int index = i % sessionNames.Length;
                sb.Append(sessionNames[index])
                  .Append(" - ")
                  .Append(sessionDates[index].ToString("dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture))
                  .Append(" - ")
                  .Append(sessionDurations[index])
                  .Append(" minutes\n");
            }
            return sb.ToString();
        }

    }
}
