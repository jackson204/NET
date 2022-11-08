using System;
using Newtonsoft.Json;

namespace JsonConvertDateTimeDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = "{\"Time\":\"2022/07/07 07:39:17.19-04:00\",\"DateTimeOffset\":\"2022/07/07 07:39:17.19-04:00\"}";
            var value = JsonConvert.DeserializeObject<MyClass>(input);
            Console.WriteLine($"time            {value.Time}");
            Console.WriteLine($"DateTimeOffset  {value.DateTimeOffset}");
            Console.WriteLine($"UtcTime         {value.UtcTime}");
        }
    }

    internal class MyClass
    {
        public DateTime Time { get; set; }

        public DateTimeOffset DateTimeOffset { get; set; }

        public DateTime UtcTime => DateTimeOffset.UtcDateTime;
    }
}