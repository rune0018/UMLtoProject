using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtoProject
{
    class Bus : Vehicle
    {
        public int Seats { get; set; }
        public int Sleeping { get; set; }
        public int Toilets { get; set; }
        public _3DObject BusObject { get; set; }
        public Bus(int seats,int sleepingSpaces,int toilets,double busHeight,double busLength,double busWeight, string name, int km, string registration,
            DateTime productionDate, double newPrice, bool trækvogn, List<string> driversLicens, int motorSize, string gastype, string energyClass)
            : base(name, km, registration, productionDate, newPrice, trækvogn, driversLicens, motorSize, gastype, energyClass)
        {
            Seats = seats;
            Sleeping = sleepingSpaces;
            Toilets = toilets;
            BusObject = new _3DObject(busHeight, busLength, 0, busWeight);
        }
    }
}
