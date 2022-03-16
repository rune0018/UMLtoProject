using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLtoProject
{
    class Auktion
    {
        private static int INC { get; set; }
        public int AuktionID { get; set; }
        public ISeller Seller { get; set; }
        public decimal MinBid { get; set; }
        public Auktion(ISeller seller,decimal minbid)
        {
            AuktionID = INC++;
            Seller = seller;
            MinBid = minbid;
        }
    }
}
