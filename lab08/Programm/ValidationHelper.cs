using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programm
{
    public class ValidationHelper
    {
        public static bool IsValidEmail(string email)
        {
            string trimmed = email.Trim();

            if (trimmed.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addres = new System.Net.Mail.MailAddress(email);
                return addres.Address == trimmed;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhone(string phone)
        {
            return Regex.Match(phone, @"^(\+[0-9]{9})$").Success;
        }
    }
}
