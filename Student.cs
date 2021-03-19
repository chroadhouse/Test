using System;
using System.Collections.Generic;
namespace UniversityC
{
    public class Student : Person
    {
        
        private List<Unit> unitsTaken;
        public Student(String name, int idNumber) : base(name, idNumber)
        {
            unitsTaken = new List<Unit>();
        }

        public void takesUnit(Unit u)
        {
            unitsTaken.Add(u);
        }

        public void dropUnit(Unit u)
        {
            foreach(Unit units in unitsTaken)
            {
                if (units == u)
                {
                    unitsTaken.Remove(units);
                }
            }
        }

        public List<Unit> getUnitsTaken()
        {
            return unitsTaken;
        }
    }
}
