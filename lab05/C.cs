using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class C : B
    {
        public C() { }

        public void Calculate(int x, int y)
        {
            base.Calculate(x, y);
            Console.WriteLine($"Iloczyn liczb {x} i {y}: {x*y}");
        }

        public override void GenRand(int x, int y)
        {
            Random rnd = new Random();
            int rand = rnd.Next(x, y);
            while (rand % 2 == 0)
            {
                rand = rnd.Next(x, y);
            }
            Console.WriteLine($"Wygenerowana liczba nieparzysta między {x} i {y}: {rand}");
        }
    }
}
