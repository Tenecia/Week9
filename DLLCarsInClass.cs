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

        public Cars ()  // 1st Constructor 
            
        {
           this.Speed= 80;
           this.Lights = false;
           this.Doors = 4;
           this.Color = "Midnight Blue";
        }

        public Cars(int Speed, bool Lights, int Doors, string Color) // Second Constructor 
    {
        this.Speed= Speed; 
        this.Lights = Lights; 
        this.Doors = Doors;
        this.Color = Color; 
    }
        public bool Stop(int Speed) // Method 1, static 
        {
            if (Speed >=1)
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

        public static int Accellerate() // Method 3
        {
            return 100;
        }

       
        
    }
}

