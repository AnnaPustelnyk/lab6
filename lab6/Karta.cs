using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public struct Student
    {
        public string Name_Surname;
        public string Nr_albumu;
    }
    public class Karta : Blank
    {
        private string FacultyS;
        private string ProfileS;
        private string StudyFormS;
        private string FieldS;
        private string LevelS;
        private string NameS;
        private string VersionEngS;
        private string DataS;
        private string RangeS;
        private string DeadlineS;
        private string PromoterS;
        private string PromoterUnitS;

        public Student[] Students { get; set; }

        public string Faculty { get => FacultyS; set => FacultyS = value; }
        public string Profile { get => ProfileS; set => ProfileS = value; }
        public string StudyForm { get => StudyFormS; set => StudyFormS = value; }
        public string Field { get => FieldS; set => FieldS = value; }
        public string Level { get => LevelS; set => LevelS = value; }
        public string Name { get => NameS; set => NameS = value; }
        public string VersionEng { get => VersionEngS; set => VersionEngS = value; }
        public string Data { get => DataS; set => DataS = value; }
        public string Range_ { get => RangeS; set => RangeS = value; }
        public string Deadline { get => DeadlineS; set => DeadlineS = value; }
        public string Promotor { get => PromoterS; set => PromoterS = value; }
        public string PromoterUnit { get => PromoterUnitS; set => PromoterUnitS = value; }

        public Karta()
        {
            Students = new Student[4];
        }
    }
}
