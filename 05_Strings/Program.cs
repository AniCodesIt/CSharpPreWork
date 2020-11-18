using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            string myInitials = "AK";
            Console.WriteLine(myInitials);


            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";
         
            Console.WriteLine(first + second);

            //result: The cars we sell are BMW, Lexus, and Mercedes.

            string firstName = "Jenn";
            string lastName = "Williams";

            Console.WriteLine("Her name is {0} {1}.", firstName, lastName);

            //result: Her name is Jenn Williams.

            string firstName1 = "Robin";
            string lastName1 = "Holler";
            //1                 //2
            Console.WriteLine($"Her name is {firstName1} {lastName1}");

            Console.ReadLine();
        }
    }
}
