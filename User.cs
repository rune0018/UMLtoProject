using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtoProject
{
    class User : IBuyer,ISeller
    {
        public int Saldo { get; set; }
        public int PostalCode { get; set; }
        public string Name { get; private set; }
        public User(string name,int saldo,int postalCode)
        {
            Saldo = saldo;
            PostalCode = postalCode;
            Name = name;
        }
        public User(string name,int saldo) : this(name,saldo, 0)
        {

        }
        public string ReciveNotifikations(IVehicle vehicle,decimal amount)
        {
            return $":{vehicle.Name}: {amount}";
        }
    }
}
