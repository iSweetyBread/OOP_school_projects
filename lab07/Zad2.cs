using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    public class Zad2
    {
        public static void Odczytywanie()
        {
            string path = "Zadanie1.txt";
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Plik nie istnieje!");
            }
        }
    }
}
