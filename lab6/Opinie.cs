using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Opinie : Blank
    {
        private string TitleS;
        private string DyplomantS;
        private string FacultyS;
        private string NrAlbumuS;
        private string FieldS;
        private string criteriumAS;
        private string criteriumBS;
        private string criteriumCS;
        private string criteriumDS;
        private string criteriumES;
        private string criteriumFS;
        private string criteriumGS;
        private string conclusionS;
        private string MarkS;
        private string MarkWordS;
        public string Title { get => TitleS; set => TitleS = value; }
        public string Dyplomant { get => DyplomantS; set => DyplomantS = value; }
        public string Faculty { get => FacultyS; set => FacultyS = value; }
        public string NrAlbumu { get => NrAlbumuS; set => NrAlbumuS = value; }
        public string Field { get => FieldS; set => FieldS = value; }
        public string criteriumA { get => criteriumAS; set => criteriumAS = value; }
        public string criteriumB { get => criteriumBS; set => criteriumBS = value; }
        public string criteriumC { get => criteriumCS; set => criteriumCS = value; }
        public string criteriumD { get => criteriumDS; set => criteriumDS = value; }
        public string criteriumE { get => criteriumES; set => criteriumES = value; }
        public string criteriumF { get => criteriumFS; set => criteriumFS = value; }
        public string criteriumG { get => criteriumGS; set => criteriumGS = value; }

        public string conclusion { get => conclusionS; set => conclusionS = value; }
        public string Mark { get => MarkS; set => MarkS = value; }
        public string MarkWord { get => MarkWordS; set => MarkWordS = value; }

    }
}
