using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class A
    {
        public A() { }

        public void Calculate(int x, int y)
        {
            Console.WriteLine($"Suma liczb {x} i {y}: {x + y}");
        }
        public virtual void GenRand(int x, int y)
        { 
            Random rnd = new Random();
            Console.WriteLine($"Wygenerowana liczba między {x} i {y} wynosi: {rnd.Next(x, y) }");
        }
    }
}
