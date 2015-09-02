using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWcovertIntToString
{
    class Program
    {
        static void Main(string[] args)
        { //Write a function that converts an int to a string. Call it from Main. Upload it to GitHub.
            int otherint = int.Parse(Console.ReadLine());
            string myConvert = IntToString(otherint);
            Console.WriteLine(myConvert);
            Console.ReadLine();

        }

        public static String IntToString(int a)
        {
           int myint = a;
           string mystring = Convert.ToString(myint);
            return mystring;            

        }

    } 

}
