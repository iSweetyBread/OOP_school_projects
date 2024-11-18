using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public abstract class Osoba
    {
        protected string firstName, lastName, pesel;

        public Osoba() { }

        public void SetFirstName(string name)
        {
            this.firstName = name;
        }
        public void SetLastName(string name)
        {
            this.lastName = name;
        }
        public void SetPesel(string pesel)
        {
            this.pesel = pesel;
        }
        public int GetAge(DateTime date)
        {
            string info = this.pesel.Substring(0, 6);

            string day = info.Substring(4, 2);
            string month = info.Substring(2, 2);
            string year = "";

            if (Int32.Parse(month) > 20)
            {
                int temp = Int32.Parse(month) - 20;
                if (temp < 10)
                {
                    month = "0" + temp.ToString();
                    
                }
                else
                { 
                    month = temp.ToString();
                }
                year += "20";
            }
            else
            {
                int temp = Int32.Parse(month);
                if (temp < 10)
                {
                    month = "0" + temp.ToString();

                }
                else
                {
                    month = temp.ToString();

                    year += "19";
                }
            }
            year += info.Substring(0, 2);

            string dateOfBirth = day + "." + month + "." + year;

            int age = date.Year - DateTime.Parse(dateOfBirth).Year;
            if (date < DateTime.Parse(dateOfBirth).AddYears(age))
            {
                age -= 1;
            }
            return age;
        }
        public void GetGender()
        { 
            int info = Int32.Parse(this.pesel.Substring(9, 1));
            if (info % 2 == 1)
            {
                Console.WriteLine("Mężczyzna");
            }
            else
            {
                Console.WriteLine("Kobieta");
            }
        }
        public void GetEducationInfo(DateTime date)
        {
            int age = this.GetAge(date);
            if (age >= 0 && age <= 3)
            {
                Console.WriteLine($"{this.GetFullName} jest w żłobku");
            }
            else if (age > 3 && age <= 6)
            {
                Console.WriteLine($"{this.GetFullName} jest w przedszkole");
            }
            else if (age > 6 && age <= 14)
            {
                Console.WriteLine($"{this.GetFullName} jest w szkole ogólnokształconcej");
            }
            else if (age > 14 && age <= 19)
            {
                Console.WriteLine($"{this.GetFullName} jest w technikum");
            }
            else
            {
                Console.WriteLine($"{this.GetFullName} jest na studiach wyższych lub pracuje");
            }
        }
        public string GetFullName()
        { 
            string fullName = this.firstName + " " + this.lastName;
            return fullName;
        }
        public bool CanGoAloneToHome(DateTime date)
        {
            int age = this.GetAge(date);
            if (age >= 12)
            { 
                return true;
            } 
            else 
            {
                return false;
            }
        }
    }
}
