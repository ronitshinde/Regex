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
                Console.WriteLine("1.Validate first name");
                Console.WriteLine();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        RegexProblem regex = new RegexProblem();
                        regex.ValidateFirstName("Phoenix");
                        Console.ReadKey();
                        break;
                }
            }        
        }
    }
}
