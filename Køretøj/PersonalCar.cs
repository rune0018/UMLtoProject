using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtoProject
{
    class PersonalCar : Car
    {
        public bool IsoFix { get; set; }
        public bool SafetyBar { get; set; }
        public int LoadCapacity { get; set; }
        public PersonalCar(bool isoFix,bool safetyBar,int loadCapacity, int seats, double bagageHeight, double bagageLength, double bagageWidth,
            string name, int km, string registration,
            DateTime productionDate, double newPrice, bool trækvogn, List<string> driversLicens, int motorSize, string gastype, string energyClass) 
            : base(seats,bagageHeight,bagageLength,bagageWidth, name, km, registration, productionDate, newPrice, trækvogn, driversLicens, motorSize, gastype, energyClass)
        {
            IsoFix = isoFix;
            SafetyBar = safetyBar;
            LoadCapacity = loadCapacity;
        }
    }
}
