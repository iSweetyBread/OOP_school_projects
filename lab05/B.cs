using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class B : A
    {
        public B() { }

        public void Calculate(int x, int y)
        {
            Console.WriteLine($"Różnica liczb {x} i {y}: {x - y}");
        }

        public override void GenRand(int x, int y)
        {
            Random rnd = new Random();
            int rand = rnd.Next(x, y);
            while (rand % 2 == 1)
            { 
                rand = rnd.Next(x, y);
            }
            Console.WriteLine($"Wygenerowana liczba parzysta między {x} i {y}: {rand}");
        }
    }
}
