using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtoProject
{
    class Lorry : Vehicle
    {
        public int LoadCapacity { get; set; }
        public _3DObject LorryObject { get; set; }
        public Lorry(int loadCapacity,double lorryHeight,double lorrryLength,double lorryWidth,double lorryWeight, string name, int km, string registration, 
            DateTime productionDate, double newPrice, bool trækvogn, List<string> driversLicens, int motorSize, string gastype, string energyClass) 
            : base(name, km, registration, productionDate, newPrice, trækvogn, driversLicens, motorSize, gastype, energyClass)
        {
            LoadCapacity = loadCapacity;
            LorryObject = new _3DObject(lorryHeight, lorrryLength, lorryWidth, lorryWeight);
        }
    }
}
