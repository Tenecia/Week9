using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsDLL;

namespace CarsInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars myCar = new Cars(); // 
            myCar.Drive();
            Cars myCar2 = new Cars();
            myCar2.Stop(45);
            myCar2.Stop(0);
           // Console.WriteLine();
            Console.ReadLine();
        }

    }
}
