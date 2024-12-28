using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    public class DatabaseManagerCSV
    {
        private static string path = "Database.csv";

        public static void Create(int id, string First_name, string Last_name, string Email, string Phone)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{id},{First_name},{Last_name},{Email},{Phone}");
            }

            Console.WriteLine("Plik zapisany pomyślnie");
        }
        public static List<string> Read()
        {
            List<string> result = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    foreach (string i in values)
                    {
                        result.Add(i.Trim());
                    }
                }
            }
            return result;
        }
        public static void Update(int id, int attribute, string data)
        {
            List<string> lines = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith(id.ToString()))
                    {
                        string[] values = line.Split(char.Parse(","));
                        values[attribute] = data;
                        line = string.Join(",", values);
                    }
                    lines.Add(line);
                }
            }

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (string i in lines)
                {
                    writer.WriteLine(i);
                }
            }
        }
        public static void Delete(int id)
        {
            List<string> lines = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith(id.ToString()))
                    {
                        continue;
                    }
                    lines.Add(line);
                }
            }

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (string i in lines)
                {
                    writer.WriteLine(i);
                }
            }
        }
        public static List<string> Search(int attribute, string data)
        {
            List<string> result = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    if (values[attribute] == data)
                    {
                        result.Add($"ID: {values[0]}\t\tFirst name: {values[1]}\t\tLast name: {values[2]}\n\nEmail: {values[3]}\t\tPhone: {values[4]}\n");
                    }
                }
            }
            return result;
        }
    }
}
