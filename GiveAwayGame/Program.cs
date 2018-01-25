using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveAwayGame
{
    class GiveAway
    {
       // string message = null;
        //string NumberSelected;
        
        static void Main(string[] args)
        {
           
            Console.WriteLine("Ben Give Away Game");
            
            // NumberSelected = Console.ReadLine();
            //bool displayResult

            ResultExit(Selection());
            
        

          
        }
        public static void ResultExit(bool message)
        {
           
            while (message == true)
            {
                message = Selection();
                
            }
            
            //Console.ReadLine();

        }
        
        public static bool Selection()
            {
           // Console.Clear();
            Console.Write("Choose a number between 1,2 or 3: ");
            string message;
            string NumberSelected = Console.ReadLine();
            Console.Clear();
            
            if (NumberSelected == "1")
            {
                message = ("Hurray!! You won a Brand New Car!");
                Console.WriteLine(message);
                

                return true;
                
            }
            else if(NumberSelected == "2")
            {
                message = ("Hurray!! You won a new Samsung TV");
                Console.WriteLine(message);

                return true;
            }

            else if (NumberSelected == "3")
            {
                message = ("You Lose. Please try again ");
                Console.WriteLine(message);
                return true;
            }
            else
            {
                message =("Application will exit because you did not enter \na valid number");
                Console.WriteLine(message);
                Console.ReadLine();
                return false;

            }
            
            //using replacement variable.
            // Console.WriteLine("You entered {0} , {1} ", NumberSelected, message);
            //Console.WriteLine(message);
            //Console.ReadLine();
        }
        
    }
}
