using System;
using System.Collections.Generic;
namespace UniversityC
{
    public class Unit
    {
        private String name;
        private String department;
        private List<Student> studentList;
        
        public Unit(String name, String departmemt)
        {
            this.name = name;
            this.department = departmemt;
            studentList = new List<Student>();
        }

        public String Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public String Department
        {
            set { this.department = value; }
            get { return this.department; }
        }

        public void enrolStudent(Student s)
        {
            Boolean enrolled = false;
            foreach(Student stu in studentList)
            {
                if (stu == s)
                {
                    enrolled = true;
                    break;
                }
            }
            if (!enrolled)
            {
                studentList.Add(s);
            }
        }
    }
}
