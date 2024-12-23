using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    public class Zad3
    {
        public static void Czyt()
        {
            string[] pesel = File.ReadAllText("pesels.txt").Split('\n');
            int count = 0;
            foreach (string p in pesel)
            {
                int a = int.Parse(p[9].ToString());
                if (a % 2 == 0)
                {
                    Console.WriteLine(p);
                    count++;
                }
            }
            Console.WriteLine($"Ilość kobiet w pliku: {count}");
        }
    }
}
