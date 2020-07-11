using System;
using System.Collections.Generic;
using SnipCLI.Models;
using System.Linq;


namespace SnipCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<SnipConfig> config = SnipConfig.ReadJsonFromFile("commands.json");


            var results = Searcher.ReturnCommands(config, args);
            



            foreach(SnipConfig snip in results)
            {
                Console.WriteLine($"{snip.HowTo} - {snip.Platform} - [{snip.CommandLine}]");
            }            
            
        }
    }
}
