using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtoProject
{
    class AH
    {
        public static List<Auktion> auktions = new();
        public delegate string Notifikation(IVehicle vehicle, decimal amount);
        public int SetForSale(IVehicle vehicle,ISeller seller,decimal minPrice)
        {
            Console.WriteLine(seller.ReciveNotifikations(vehicle, minPrice));
            Auktion temp = new Auktion(seller, minPrice);
            auktions.Add(temp);
            return temp.AuktionID; //placeHolder
        }
        public int SetForSale(IVehicle vehicle, ISeller seller, decimal minPrice, Notifikation N)
        {
            Auktion temp = new Auktion(seller, minPrice);
            auktions.Add(temp);
            Console.WriteLine(N(vehicle, minPrice));
            return temp.AuktionID;
        }
        public bool ReciveBid(IBuyer buyer,int auktionnumber,decimal bid)
        {
            return true;
        }
    }
}
