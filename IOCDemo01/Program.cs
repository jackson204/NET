using System;
using Microsoft.Extensions.DependencyInjection;

namespace IOCDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            // var testServiceImpl = new TestServiceImpl();
            // testServiceImpl.Name = "Tom";
            // testServiceImpl.SayHi();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<TestServiceImpl>();
            using (var buildServiceProvider = serviceCollection.BuildServiceProvider())
            {
                var testServiceImpl = buildServiceProvider.GetService<TestServiceImpl>();
                testServiceImpl.Name = "HH";
                testServiceImpl.SayHi();
            }
           
        }
    }

    public interface ITestService
    {
        public string Name {
            get;
            set;
        }

        public void SayHi();
    }

    public class TestServiceImpl : ITestService
    {
        public string Name { get; set; }

        public void SayHi()
        {
            Console.WriteLine($"Hi i {Name}");
        }
        
    }
    public class TestServiceImpl2 : ITestService
    {
        public string Name { get; set; }

        public void SayHi()
        {
            Console.WriteLine($"Hi TestServiceImpl2i {Name}");
        }
        
    }
    
}