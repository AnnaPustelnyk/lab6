using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class OpinieR : Opinie
    {
        private string RecenzentS;
        private string UnitRs;
        public string Recenzent { get => RecenzentS; set => RecenzentS = value; }
        public string UnitR { get => UnitRs; set => UnitRs = value; }
    }
}
