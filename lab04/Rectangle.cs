using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Rectangle : Shape
    {
        public Rectangle(double x, double y, double height) : base(x, y, height) 
        { 
            this.x = x;
            this.y = y;
            this.height = height;
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Prostokąt");
        }
    }
}
