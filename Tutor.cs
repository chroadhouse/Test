using System;
namespace UniversityC
{
    public class Tutor : Person
    {
        private Unit unitTaught;
        public Tutor(String name, int idNumber, Unit unitTaught):base(name,idNumber)
        {
            this.unitTaught = unitTaught;
        }

        public Unit UnitTaught
        {
            set { this.unitTaught = value; }
            get { return this.unitTaught; }
        }
    }
}
