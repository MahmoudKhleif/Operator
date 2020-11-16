using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beräkningar
{
    class MatmatiskaBeräkningar
    {   /*created a new class which contains 4 methods and these methods perform 
        the Four arithmetic operations and then we can call methods when we need them 
        
        defined 5 variables at the class level as a static,
        to be able to use it all over the class*/
        static char w, e;
        static double a, b, c;

        // the first arithmetic operation (addiation)
        public void Addition(char w, char e, int a, int b, int c)
        {

            if ((w == '+') && (e == '*'))
            {
                Console.WriteLine(a + " + " + b + " * " + c + " = " + (a + b * c));

            }
            else if ((w == '+') && (e == '-'))
            {
                Console.WriteLine(a + " + " + b + " - " + c + " = " + (a + b - c));
            }
            else if ((w == '+') && (e == '+'))
            {
                Console.WriteLine(a + " + " + b + " + " + c + " = " + (a + b + c));
            }
            else if ((w == '+') && (e == '/'))
            {
                Console.WriteLine(a + " + " + b + " / " + c + " = " + (a + b / c));
            }

        }
        // the second arithmetic operation(Multiplikation)
        public void Multiplikation(char w, char e, int a, int b, int c)
        {
            if ((w == '*') && (e == '*'))
            {
                Console.WriteLine(a + " * " + b + " * " + c + " = " + (a * b * c));

            }
            else if ((w == '*') && (e == '-'))
            {
                Console.WriteLine(a + " * " + b + " - " + c + " = " + (a * b - c));
            }
            else if ((w == '*') && (e == '+'))
            {
                Console.WriteLine(a + " * " + b + " + " + c + " = " + (a * b + c));
            }
            else if ((w == '*') && (e == '/'))
            {
                Console.WriteLine(a + " * " + b + " / " + c + " = " + (a * b / c));
            }
        }
        // the third arithmetic operation(Subtraktion)
        public void Subtraktion(char w, char e, int a, int b, int c)
        {
            if ((w == '-') && (e == '*'))
            {
                Console.WriteLine(a + " - " + b + " * " + c + " = " + (a - b * c));

            }
            else if ((w == '-') && (e == '-'))
            {
                Console.WriteLine(a + " - " + b + " - " + c + " = " + (a - b - c));
            }
            else if ((w == '-') && (e == '+'))
            {
                Console.WriteLine(a + " - " + b + " + " + c + " = " + (a - b + c));
            }
            else if ((w == '-') && (e == '/'))
            {
                Console.WriteLine(a + " - " + b + " / " + c + " = " + (a - b / c));
            }

        }
        // the fourth arithmetic operation(Delning)
        public void Delning(char w, char e, int a, int b, int c)
        {
            if ((w == '/') && (e == '*'))
            {
                Console.WriteLine(a + " / " + b + " * " + c + " = " + (a / b * c));

            }
            else if ((w == '/') && (e == '-'))
            {
                Console.WriteLine(a + " / " + b + " - " + c + " = " + (a / b - c));
            }
            else if ((w == '/') && (e == '+'))
            {
                Console.WriteLine(a + " / " + b + " + " + c + " = " + (a / b + c));
            }
            else if ((w == '/') && (e == '/'))
            {
                Console.WriteLine(a + " / " + b + " / " + c + " = " + (a / b / c));
            }
        }
    }
}
  
