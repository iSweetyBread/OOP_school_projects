using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    public class Zad1
    {
        public static void Zapisanie()
        {
            string path = "Zadanie1.txt";
            string text = "w69976";
            File.WriteAllText(path, text);
            Console.WriteLine("Plik został stworzony!");
        }
    }
}
