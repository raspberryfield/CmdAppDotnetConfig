using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Serilog;
using Serilog.Core;
using System;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConsoleApp3 - Testing different approaches of logging.");
            
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json")
                .Build();            


            Console.WriteLine(config["path_log_directory"]);

            var logger = new LogHandler().Logger;

            logger.Information(">> This is just a test!");

        }
    }
}
