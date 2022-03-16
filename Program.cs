using System;
using System.Collections.Generic;

namespace UMLtoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IVehicle vehicle1 = new PersonalCar(false, false, 1, 10, 10, 10, 10, "test1", 1, "ab12345", DateTime.Now, 1, false, new List<string>(), 4, "Photons", "a++++++++++");
            Console.WriteLine(vehicle1.Gastype + " energy class: "+vehicle1.EnergyClass);
            
        }
    }
}
