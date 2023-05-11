using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace RegexPatterns
{
    internal class CreateRegexPatterns
    {
        public static void PhoneNumberPattern()
        {
            string[] input = { "8407958538", "9561665172", "7541457562" };
            string pattern = "[8 9][0-9]{9}";  // starts with 8 or 9 , contains 9 numbers betn 0 to 9 
            Console.Write("\ninput phone numbers are: ");
            foreach( string s in input)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
            foreach(string s in input)
            {
                if(Regex.IsMatch(s,pattern)) // return true or false 
                {
                    Console.WriteLine($"Valid Phone Number: {s}");
                }
            }   
        }
     
    }
}
