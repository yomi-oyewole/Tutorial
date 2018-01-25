using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrintProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = 1;
            string message = null ;
            while (P < 51)

            {
                if(P % 3 == 0 && P % 5 == 0)
                {
                   
                    Console.WriteLine("WIN");
                    
                }
                else if (P % 3 == 0)
                {
                   
                    message = " :) ";
                   
                }
                else if (P % 5 == 0 )
                {
                    
                    message = " :( ";
                   
                }
                else
                {
                    
                    message = Convert.ToString(P);
                   
                }
                P++;
                Console.WriteLine("value of P is: " + message);
                
            }
            Console.ReadLine();

            
            
        }

    }
}
