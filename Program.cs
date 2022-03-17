using System;
using System.Collections.Generic;

namespace UMLtoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle1 = new PersonalCar(false, false, 1, 10, 10, 10, 10, "test1", 1, "ab12345", DateTime.Now, 1, false, new List<string>(), 4, "Photons", "a++++++++++");
            Console.WriteLine(vehicle1.Gastype + " energy class: "+vehicle1.EnergyClass);

            var User1 = new User("hejsa",1000, 312312);
            var User2 = new User("hejsa 2", 10000, 334545);
            

            AH.SetForSale(vehicle1, User1, 20, User2.ReciveNotifikations);
            AH.SetForSale(vehicle1, User1, 20);
            AH.SetForSale(vehicle1, User1, 20);
            
            AH.ShowResults(AH.auktions);

            AH.ReciveBid(User1, 1, 100);
            
            AH.ShowResults(AH.auktions);

            AH.AcceptBid(User1, 1);
            
            AH.ShowResults(AH.auktions);
        }
    }
}
