using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Uczen : Osoba
    {
        protected string Szkola { get; set; }
        protected bool MozeSamWracacDoDomu { get; set; }

        public Uczen() { }

        public void SetSchool(string school)
        { 
            this.Szkola = school;
        }
        public void ChangeSchool(string school)
        { 
            SetSchool(school);
        }
        public void SetCanGoHomeAlone(DateTime date)
        { 
            this.MozeSamWracacDoDomu = base.CanGoAloneToHome(date);
        }
    }
}
