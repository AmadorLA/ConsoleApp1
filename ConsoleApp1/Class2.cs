using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Vehiculo
    {
        private string color;
        private Motor motor;



        public string Color
        {
            get 
            { 
                return Color;
            }
            set 
            { 
                Color = value;
            }
        }

        

        public Motor Motor
        {
            get 
            { 
                return Motor; 
            }
            set 
            { 
                Motor = value; 
            }
        }

        public Vehiculo()
        {
            color = "";
            motor = new Motor();
        }

        public Vehiculo(String color, Motor motor)
        {
            this.color = color;
            this.motor = motor;
        }

        public override string ToString()
        {
            return base.ToString() + "--> color:" + color +",Motor[" + motor.ToString() + "]";
        }


    }
}
