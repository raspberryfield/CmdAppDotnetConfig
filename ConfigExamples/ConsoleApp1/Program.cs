using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World - ConsoleApp1.");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json");

            var config = builder.Build();

            Console.WriteLine(config["TestSetting1"]);
            Console.WriteLine(config["TestSetting2:SubSetting1"]); //SubSetting1

        }
    }
}
