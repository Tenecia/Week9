using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9PosIntExceptionHW
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that takes a positive int from the console and
            //  prints the square root of the int (Try).If the input is negative or invalid,
            // print "Invalid Number" to the console(Catch).In all cases, print "Goodbye." (Fianlly).
            try
            {
                int myint = int.Parse(System.Console.ReadLine()); // *int from Console
                if (myint < 0)
                {
                    throw new Exception("Invalid Number");
                }
                double squareInt = Math.Sqrt(myint);
                System.Console.WriteLine(squareInt);
            }

            catch(Exception e) // Always write Exception (Exception) and then name it Ex : "e" . 
            {// *if input is negative or invalid print to Console " Invalid Number"
                Console.WriteLine("Invalid Number");
            }
            finally
            { //* In all cases print "GoodBye"
                Console.WriteLine("GoodBye");

            }
            Console.ReadLine();           

        }
    }
}
