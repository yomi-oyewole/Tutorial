using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] Numbers = new int[5];
             Numbers[0] = 1;
             Numbers[1] = 3;
             Numbers[2] = 32;
             Numbers[3] = 11;
             int size = Numbers.Length;
             Console.WriteLine(size);
             foreach (int Num in Numbers)
             {
                 Console.WriteLine(Num);
             }
             Console.ReadLine(); */

            /*   int[] Numbers = new int[] { 3, 4, 5 };
               for (int i = 0; i < Numbers.Length; i++)
               {
                   Console.WriteLine(Numbers[i]);

               }
               Console.Read(); */
            Console.Write("Enter your message: ");
            string Quote = Console.ReadLine();
            Console.WriteLine("Original Message: " + Quote);

            //string Quote = "I love abake";

            char[] ConvertQ = Quote.ToCharArray();
            Array.Reverse(ConvertQ);
            Console.Write("Reversed Message: ");
            foreach (char ConV in ConvertQ)
              
            {
                Console.Write(ConV);
            }
            Console.ReadLine();
        }
    }
}
