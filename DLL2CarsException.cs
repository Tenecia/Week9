using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsDLL
{
    public class Cars
    {
        private int speed;
        private bool lights;
        private int doors;
        private string color;
        public const int MaxSpeed = 100;
        private string carName;
        private bool carIsDead;

        public string CarName // petname
        {
            get { return this.carName; }
            set { this.carName = value; }
        }

        public int Speed // 1 st Property 
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        public bool Lights // 1 st Property 
        {
            get { return this.lights; }
            set { this.lights = value; }
        }
        public int Doors // 1 st Property 
        {
            get { return this.doors; }
            set { this.doors = value; }
        }
        public string Color // 1 st Property 
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Cars()  // 1st Constructor 
        {
            this.Speed = 45;
            this.Lights = false;
            this.Doors = 4;
            this.Color = "Midnight Blue";
            this.CarName = "Hot Wheels!";
        }

        public Cars(int Speed, bool Lights, int Doors, string Color, string Name) // Second Constructor 
        {
            this.Speed = Speed;
            this.Lights = Lights;
            this.Doors = Doors;
            this.Color = Color;
            this.CarName = Name;
        }
        public bool Stop(int Speed) // Method 1, static 
        {
            if (Speed >= 1)
            {
                this.Lights = true;
            }

            else
            {
                this.Lights = false;
            }
            Console.WriteLine(" Your car is stopped, are your lights on?  " + this.Lights);
            return true;
        }

        public void Drive() // Method 2
        {
            Console.WriteLine("Our car is   " + this.Color + "   and drives   " + this.Speed + "   mph");
        }

        public void Accellerate(int delta) // Method 3
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", CarName);
            else
            {
                Speed += delta;
                if (Speed >= MaxSpeed)
                {
                    
                    Speed = 0;
                    carIsDead = true;
                    Exception ex =
                        new Exception(string.Format("{0} has overheated!", CarName));
                    ex.HelpLink = "http://www.CarsRUs.com";
                    throw ex;
                }
                else
                    Console.WriteLine("=> Speed = {0}", Speed);
                
            }

        }
    }
}

