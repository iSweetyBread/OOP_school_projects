using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Triangle : Shape
    {
        public Triangle(double x, double y, double height) : base(x, y, height)
        {
            this.x = x;
            this.y = y;
            this.height = height;
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Trójkąt");
        }
    }
}
