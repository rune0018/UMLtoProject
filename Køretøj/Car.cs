using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtoProject
{
    abstract class Car : Vehicle
    {
        public int Seats { get; set; }
        public _3DObject Bagage { get; set; }
        protected Car(int seats,double bagageHeight, double bagageLength,double bagageWidth, string name, int km, string registration,
            DateTime productionDate, double newPrice, bool trækvogn, List<string> driversLicens, int motorSize, string gastype, string energyClass)
            : base(name,km,registration,productionDate,newPrice,trækvogn,driversLicens,motorSize,gastype,energyClass)
        {
            Seats = seats;
            Bagage = new _3DObject(bagageHeight, bagageLength, bagageWidth);
        }
    }
}
