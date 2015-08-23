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
            Console.WriteLine();
            //Console.ReadLine();
            Console.WriteLine("***Simple Exception Example***");
            Console.WriteLine("=>Creating a Car and then stepping on it!");
            Cars myCar3 = new Cars();

            // for (int i = 0; i < 10; i++)
           // myCar3.Accellerate(10);
            //Console.ReadLine();
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar3.Accellerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n***Error***");
                Console.WriteLine("Method:{0}", e.TargetSite);
                Console.WriteLine("Message:{0}", e.Message);
                Console.WriteLine("Source:{0}", e.Source);
                Console.WriteLine("Help Link:{0}", e.HelpLink);
            }
            Console.WriteLine("\n****Out of exception logic****");
            Console.ReadLine();

        }


    }
}