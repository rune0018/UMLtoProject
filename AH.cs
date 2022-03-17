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
        public static int SetForSale(IVehicle vehicle,ISeller seller,decimal minPrice)
        {
            Console.WriteLine(seller.ReciveNotifikations(vehicle, minPrice));
            Auktion temp = new Auktion(seller, minPrice, vehicle);
            auktions.Add(temp);
            return temp.AuktionID; //placeHolder
        }
        public static int SetForSale(IVehicle vehicle, ISeller seller, decimal minPrice, Notifikation N)
        {
            Auktion temp = new Auktion(seller, minPrice, vehicle);
            auktions.Add(temp);
            Console.WriteLine(N(vehicle, minPrice));
            return temp.AuktionID;
        }
        public static bool ReciveBid(IBuyer buyer,int auktionNumber,decimal bid)
        {
            var search = auktions.Where(a => a.AuktionID == auktionNumber).ToList();
            if (search[0].MinBid > bid || buyer.Saldo<bid) return false;
            search[0].MinBid = bid;
            return true;
        }

        public static bool AcceptBid(ISeller seller,int auktionNumber)
        {
            var search = auktions.Where(a => a.AuktionID == auktionNumber).ToList();
            if (search.Count() == 0) return false;
            auktions.Remove(search[0]);
            Console.WriteLine("Accepted bid " + seller.ReciveNotifikations(search[0].Vehicle, search[0].MinBid));
            return true;
        }
        public static void ShowResults(List<Auktion> auk)
        {
            Console.WriteLine("----------------------------");
            foreach (Auktion a in auk)
            {
                Console.WriteLine(a.AuktionID + " : " + a.Vehicle.Name + " : " + a.MinBid + " : "+ a.Seller);
            }
            Console.WriteLine("============================");
        }
    }
}
