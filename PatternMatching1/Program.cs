using System;
using System.Text.RegularExpressions;

namespace PatternMatching1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Pattern Matching Problem");

            

            String Pattern = "^[1-9]{1}[0-9]{5}$";

            Regex r = new Regex(Pattern);

            String pinNo = Console.ReadLine();

            if(r.IsMatch(pinNo))
            {
                Console.WriteLine("Valid PIN number");

            }
            else
            {
                Console.WriteLine("Invalid PIN number");

            }
        
        }
    }
}
