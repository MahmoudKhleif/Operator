using Beräkningar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Beräkningar
{
    class Program
    {   // defined 5 variables at the class level as a static,
        // to be able to use it all over the class
        static char w, e;
        static int num1, num2, num3;
       
       //this method asks the user to enter 2 operators and 3 numbers.
        static void Console1()
        {
            Console.WriteLine(" Enter first operator: ");
            w = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(" Enter second operator: ");
            e = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(" Enter first Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  Enter third Number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {   
            MatmatiskaBeräkningar Beräkningar = new MatmatiskaBeräkningar();

            string yes; // this variable for asking the user if wants to try again
                        // and we use it in <<do- while>>> loop
            do
            {
                Console1(); // call the method which ask user to input item

                // call the methods which have the Four arithmetic operations
                Beräkningar.Addition(w, e, num1, num2, num3);
                Beräkningar.Multiplikation(w, e, num1, num2, num3);
                Beräkningar.Subtraktion(w, e, num1, num2, num3);
                Beräkningar.Delning(w, e, num1, num2, num3);

          Console.WriteLine("Enter y if you want try again or any letter to Exit: ");
           yes = Console.ReadLine();
             } while (yes == "y" || yes == "Y"); // do-while loop to repeat code

        }
    }
}


