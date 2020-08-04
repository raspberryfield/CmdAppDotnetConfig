using System;
using Serilog;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Log.Logger = new LoggerConfiguration()
                    .WriteTo.File("my_log.txt")
                    .CreateLogger();

            Log.Information("I am logging now =) .");

        }
    }
}
