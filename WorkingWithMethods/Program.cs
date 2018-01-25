using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple reverse Name App");
            Console.Write("Please enter First Name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Please Enter Last Name: ");
            string LastName = Console.ReadLine();
            Console.Write("Please enter city you were born: ");
            string City = Console.ReadLine();
            Console.WriteLine("Original result: " + FirstName + " " + LastName + " " + City);

            //string result = Console.WriteLine("Result: ")

            DisplayResult(ReturnArrayNames(FirstName), ReturnArrayNames(LastName), ReturnArrayNames(City));
            DisplayResult(ReturnArrayNames(FirstName));

    

        }
        private static string ReturnArrayNames(string message)
        {
            char[] MessageChae = message.ToCharArray();
            Array.Reverse(MessageChae);
            return String.Concat(MessageChae);
        }
        private static void DisplayResult(string ReversedFirstName,
                                          string ReversedLastName,
                                          string ReversedCity)
        {
            Console.WriteLine("Reversed Result: {2} {1} {0}", 
                            ReversedFirstName, 
                            ReversedLastName, 
                            ReversedCity);
            Console.ReadLine();
           
                        
        }
        private static void DisplayResult(string message)
        {
            Console.Write("result: ");
            Console.WriteLine(message);
            Console.ReadLine();
        }


    }
}
