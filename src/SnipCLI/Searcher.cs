using System.Collections.Generic;
using SnipCLI.Models;
using System.Linq;

namespace SnipCLI
{
    public class Searcher
    {
        public static List<SnipConfig> ReturnCommands(List<SnipConfig> rawList, string[] args)
        {
            var results = from r in rawList where r.CommandLine.Contains("run") select r;

            return results.ToList();
        }
    }
}