using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Registratoion
    {
        public void Check(string name)
        {
            //regex pattern is created to check validity
            string pattern = "[A-Z][a-z]{3}[a-z]*";
            Regex regex = new Regex(pattern);
            // IsMatch method check the pattern and name
            if (regex.IsMatch(name))
            {
                Console.WriteLine("Name {0} is Valid ", name);
            }
            else
            {
                Console.WriteLine("Name {0} is Invalid", name);
            }
        }
        public void CheckMail(string mail)
        {
            //regex pattern is created to check validity
            string pattern = @"^[A-Za-z0-9]+([\.+\-_][A-Za-z0-9]+)*@[a-zA-Z0-9]+\.?[A-Za-z]+\.?[A-Za-z]{2,}$";
            Regex regex = new Regex(pattern);
            // IsMatch method check the pattern and mail
            if (regex.IsMatch(mail))
            {
                Console.WriteLine("Email :{0} is Valid", mail);
            }
            else
            {

                Console.WriteLine("Email :{0} is Invalid", mail);
            }
        }
        public void CheckPhoneNumber(string PhoneNumber)
        {
            //regex pattern is created to check validity
            string pattern = "^[1-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
            Regex regex = new Regex(pattern);
            // IsMatch method check the pattern and mail
            if (regex.IsMatch(PhoneNumber))
            {
                Console.WriteLine("PhoneNumber :{0} is Valid", PhoneNumber);
            }
            else
            {
                Console.WriteLine("PhoneNumber :{0} is Invalid", PhoneNumber);

            }
        }
        public void CheckPassword(string Password)
        {
            //regex pattern is created to check validity
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[~`!@#$%^&*_+=,./?]).{8,}$";
            Regex regex = new Regex(pattern);
            // IsMatch method check the pattern and mail
            if (regex.IsMatch(Password))
            {
                Console.WriteLine("Password :{0} is Valid", Password);
            }
            else
            {
                Console.WriteLine("Password :{0} is Invalid", Password);

            }
        }
    }
}
