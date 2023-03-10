using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the option number");
                Console.WriteLine("1.Validate first name \n2.Validate last name \n3.Validate email id \n4.Validate phone no \n5.Password minimum eight characters \n6.Password with atleast one upper case \n7.Password with atleast one number \n8.Password with only one special character \n0.Exit");
                Console.WriteLine();
                RegexProblem regex = new RegexProblem();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        regex.ValidateFirstName("Phoenix");
                        break;
                    case 2:
                        regex.ValidateLastName("Cruise");
                        break;
                    case 3:
                        regex.ValidateEmailId("abc.xyz@bl.co.in");
                        break;
                    case 4:
                        regex.ValidatePhoneNumber("91 7894561232");
                        break;
                    case 5:
                        regex.ValidatePassword("abCDef784");
                        break;
                    case 6:
                        regex.ValidateString("Phoenix123");
                        break;
                    case 7:
                        regex.ValidateNumericPassword("Phoe123nixrise145");
                        break;
                    case 8:
                        regex.ValidateSpecialCharacter("Phoenix@123");
                        break;
                    case 0:
                        flag = false;
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
