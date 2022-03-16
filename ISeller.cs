using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtoProject
{
    interface ISeller
    {
        public int Saldo { get; set; }
        public int PostalCode { get; set; }
        public string ReciveNotifikations(IVehicle vehicle, decimal amount);
    }
}
