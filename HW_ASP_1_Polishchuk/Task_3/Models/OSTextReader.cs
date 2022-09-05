using System;
using System.Collections.Generic;
using System.IO;

namespace Task_3.Models
{
    public class OSTextReader
    {
        private readonly string path = "App_Data/data.txt";

        public List<OperatingSystem> ReadFromFile()
        {
            string[] lines = File.ReadAllLines(path);

            List<OperatingSystem> result = new List<OperatingSystem>();
            foreach (string line in lines)
            {
                string[] item = line.Split(',');

                OperatingSystem operatingSystem = new OperatingSystem();
                operatingSystem.Id = Convert.ToInt32(item[0]);
                operatingSystem.Name = item[1];

                result.Add(operatingSystem);
            }

            return result;
        }
    }
}
