using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Nauczyciel : Uczen
    {
        protected string tytulNaukowy;
        protected List<Uczen> podwladniUczniowie = new List<Uczen>();

        public Nauczyciel() { }

        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            foreach (Uczen stud in podwladniUczniowie)
            {
                if (stud.CanGoAloneToHome(dateToCheck))
                {
                    Console.WriteLine(stud.GetFullName());
                }
            }
        }
        public void AddStud(Uczen stud)
        { 
            podwladniUczniowie.Add(stud);
        }
        public void AddStud(List<Uczen> students)
        {
            foreach (Uczen student in students)
            {
                AddStud(student);
            }
        }
    }
}
