using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtoProject
{
    interface IVehicle
    {
        public string Name { get; set; }
        public int Km { get; set; }
        public string Registration { get; set; }
        public DateTime ProductionDate { get; set; }
        public double NewPrice { get; set; }
        public bool Trækvogn { get; set; }
        public List<string> DriversLicens { get; set; } // could be a class
        public int MotorSize { get; set; }
        public string Gastype { get; set; }
        public string EnergyClass { get; set; }
    }
}
