using System;
using System.Text.JSON;
using System.IO;

namespace SerializationExample
{
    public class Staplers
    {
        public string color { get; set; }
        public string brand { get; set; }
        public int stapleSize { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var stapler = new Staplers
            {
                color = "Red",
                brand = "Swingline",
                stapleSize = 22
            };

            string filePath = "C:\Users\BigJimbo\Desktop\AllMyStaplers.csv";
            string jsonString = JSONSerializer.Serialize(stapler);
            File.WriteAllText(filePath, jsonString);

            Console.WriteLine(File.ReadAllText(filePath));

        }
    }
}