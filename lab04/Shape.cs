using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Shape
    {
        protected double x, y, height;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Height
        { 
            get { return height; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Wysokość musi być większa od zera");
                }
                height = value;
            }
        }

        public Shape(double x, double y, double height)
        { 
            this.x = x;
            this.y = y;
            this.height = height;
        }

        public virtual void Draw()
        {
            Console.Write($"Próbujemy narysować ");
        }
    }
}
