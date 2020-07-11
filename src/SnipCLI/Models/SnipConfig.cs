using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SnipCLI.Models
{
    public class SnipConfig
    {
        public string HowTo {get; set;}
        public string Platform { get; set; }
        public string CommandLine { get; set; }

        public static List<SnipConfig> ReadJsonFromFile(string file)
        {
            var filePath = "D:\\SnipCLI\\src\\SnipCLI\\" + file;
            //Console.WriteLine($"File Path: {filePath}");
            try
            {
                string json = File.ReadAllText(filePath);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<SnipConfig>>(json);
                

            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Could not read config file: {filePath}, Excption: {ex.Message}");
                Console.ResetColor();
                return null;    
            } 

            
        }
    }
}