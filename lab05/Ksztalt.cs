using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public abstract class Ksztalt : ICloneable
    {
        public string Nazwa { get; set; }

        public Ksztalt(string nazwa) 
        { 
            Nazwa = nazwa;
        }
        public Ksztalt() { }

        public virtual object Clone()
        {
            throw new NotImplementedException();
        }
        public virtual double Obwod()
        {
            throw new NotImplementedException();
        }
        public virtual void Przesun(double x, double y)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Kształt: " + Nazwa;
        }
        public override bool Equals(object? obj)
        {
            var item = obj as Ksztalt;
            if (this.Nazwa == item.Nazwa)
            {
                return true;
            }
            return false;
        }
    }
}
