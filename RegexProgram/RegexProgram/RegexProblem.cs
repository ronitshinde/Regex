using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public class RegexProblem
    {
        public void ValidateFirstName(string name)
        {
            //Phoenix
            string firstName = "^[A-Z]{1}[a-z]{3,}?";
            if (Regex.IsMatch(name, firstName))
            {
                Console.WriteLine("First Name is matching with Regex");
            }
            else
            {
                Console.WriteLine("First Name is not matching with Regex");
            }
        }
        public void ValidateLastName(string name)
        {
            //Cruise
            string lastName = "^[A-Z]{1}[a-z]{3,}?";
            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("Last Name is matching with Regex");

            }
            else
            {
                Console.WriteLine("Last Name is not matching with Regex");
            }
        }
        public void ValidateEmailId(string emailId)
        {
            string email = "^[a-zA-Z]+[.+_-]{1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            if (Regex.IsMatch(emailId, email))
            {
                Console.WriteLine("Email is matching");
            }
            else
            {
                Console.WriteLine("Email is not matching");
            }
        }
        public void ValidatePhoneNumber(string phoneNumber)
        {
            string number = @"[0-9]{2}\s[0-9]{10}";
            if (Regex.IsMatch(phoneNumber, number))
            {
                Console.WriteLine("Number is matching");
            }
            else
            {
                Console.WriteLine("Number is not matching");
            }
        }
        public void ValidatePassword(string password)
        {
            string pass = @"[A-Z a-z 0-9]{8,}"
;
            if (Regex.IsMatch(password, pass))
            {
                Console.WriteLine("Password is matching");
            }
            else
            {
                Console.WriteLine("Password is not matching");
            }
        }
        public void ValidateString(string passWord)
        {
            string name = @"(?=.*[A-Z])[A-Za-z0-9]{8,}";

            if (Regex.IsMatch(passWord, name))
            {
                Console.WriteLine("It is matching with Regex");
            }
            else
            {
                Console.WriteLine("It is not matchng with Regex");
            }
        }
        public void ValidateNumericPassword(string numPassword)
        {
            string passWord = "[a-zA-Z][0-9]{1,}";
            if (Regex.IsMatch(numPassword, passWord))
            {
                Console.WriteLine("Numeric password is matching with Regex");
            }
            else
            {
                Console.WriteLine("Numeric password is not matching with Regex");
            }
        }
    }
}
