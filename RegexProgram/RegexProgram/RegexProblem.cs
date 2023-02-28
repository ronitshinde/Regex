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
            string lastName = "^[A - Z]{1}[a - z]{3,}?";
            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("Last Name is matching with Regex");

            }
            else
            {
                Console.WriteLine("Last Name is not matching with Regex");
            }
        }
    }
}
