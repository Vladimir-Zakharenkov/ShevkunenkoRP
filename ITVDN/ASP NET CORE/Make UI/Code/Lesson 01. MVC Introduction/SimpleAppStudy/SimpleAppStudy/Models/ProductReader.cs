using System;
using System.Collections.Generic;
using System.IO;

namespace SimpleAppStudy.Models
{
    public class ProductReader
    {
        public readonly string path = "Data/data.txt";

        public List<Product> ReadFromFile()
        {
            string[] lines = File.ReadAllLines(path);

            List<Product> result = new();

            foreach (var line in lines)
            {
                string[] itemes = line.Split(',');

                Product product = new()
                {
                    Id = Convert.ToInt32(itemes[0].Trim()),
                    Name = itemes[1].Trim(),
                    Price = Convert.ToDouble(itemes[2].Trim())
                };

                result.Add(product);
            }

            return result;
        }
    }
}
