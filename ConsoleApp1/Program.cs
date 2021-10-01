
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor motor = new Motor();
            motor.Tipo = "Full Injection";
            motor.Potencia = 10.5;
            Vehiculo veh = new Vehiculo("NEGRO",motor);

            Console.WriteLine(veh.ToString());
            
        }
    }
}
