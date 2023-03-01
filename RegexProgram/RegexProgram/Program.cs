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
                Console.WriteLine("1.Validate first name \n2.Validate last name \n3.Validate email id \n0.Exit");
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
                    case 0:
                        flag = false;
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
