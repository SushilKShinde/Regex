using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regex (regular expressio) implementation ");
            Console.WriteLine("Choose a Option from below");
            Console.WriteLine("1.Validate Phone Number\n2.Validate First name ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateRegexPatterns.PhoneNumberPattern();
                    break;
                case 2:

                    break;
                default:
                    Console.WriteLine("Choose valid option");
                    break;
            }

        
        }
    }
}
