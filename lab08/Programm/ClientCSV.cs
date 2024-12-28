using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    public class ClientCSV
    {
        private static int idCounter = 0;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ClientCSV(string firstName, string lastName, string email, string phone)
        {
            if (!ValidationHelper.IsValidEmail(email))
            {
                throw new ArgumentException("Invalid email address");
            }
            if (!ValidationHelper.IsValidPhone(phone))
            {
                throw new ArgumentException("Invalid phone number");
            }
            Id = ++idCounter;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
        }
    }
}
