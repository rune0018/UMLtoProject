using System;
using System.Collections.Generic;

namespace UMLtoProject
{
    abstract class Vehicle : IVehicle,IComparable
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

        protected Vehicle(string name,int km,string registration, DateTime productionDate, double newPrice, bool trækvogn, 
            List<string> driversLicens, int motorSize, string gastype, string energyClass)
        {
            Name = name;
            Km = km;
            Registration = registration;
            ProductionDate = productionDate;
            NewPrice = newPrice;
            Trækvogn = trækvogn;
            DriversLicens = driversLicens;
            MotorSize = motorSize;
            Gastype = gastype;
            EnergyClass = energyClass;
        }

        public int CompareTo(object obj)
        {
            return Name.CompareTo(obj);
        }
    }
}
