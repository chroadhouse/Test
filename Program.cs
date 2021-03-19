using System;
using System.Collections.Generic;
namespace UniversityC
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit unitOne = new Unit("Algorithms and data structures", "Science and engineering");
            Unit unitTwo = new Unit("Professional development", "Science and engineering");
            Unit unitThree = new Unit("Advanced programming", "Science and engineering");

            List<Tutor> tutorList = new List<Tutor>();
            tutorList.Add(new Tutor("Matteo Cavaliere", 100, unitOne));
            tutorList.Add(new Tutor("Matthew Crossley", 101, unitTwo));
            tutorList.Add(new Tutor("Kris Welsh", 102, unitThree));

            List<Student> students = new List<Student>();
            students.Add(new Student("Charlie", 200));
            students.Add(new Student("Jonathon", 201));
            students.Add(new Student("Emily", 203));
            students.Add(new Student("Christian", 204));

            students[0].takesUnit(unitOne);
            students[0].takesUnit(unitTwo);
            students[0].takesUnit(unitThree);
            students[1].takesUnit(unitOne);
            students[1].takesUnit(unitTwo);
            students[1].takesUnit(unitThree);
            students[2].takesUnit(unitTwo);
            students[3].takesUnit(unitThree);
            Console.WriteLine("Done");

        }
    }
}
