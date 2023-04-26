using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class OpinieP : Opinie
    {
        private string PromotorS;
        private string UnitPs;
        private string criteriumHS;

        public string Promotor { get =>  PromotorS; set => PromotorS = value; }
        public string UnitP { get => UnitPs; set => UnitPs = value; }
        public string criteriumH { get => criteriumHS; set => criteriumHS = value; }
    }
}
