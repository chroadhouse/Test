using System;
namespace UniversityC
{
    public class Person
    {
        private int idNumber;
        private String name;

        public Person(String name, int idNumber)
        {
            this.name = name;
            this.idNumber = idNumber;
        }

        public String Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public int Idnumber
        {
            set { this.idNumber = value; }
            get { return this.idNumber; }
        }
    }
}
