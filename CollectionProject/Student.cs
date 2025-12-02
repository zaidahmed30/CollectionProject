using System;
using System.Collections.Generic;

namespace CollectionProject
{
    public class Student : IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(Student other)
        {
            if(this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
        }
    }

    public class CompareStudents : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if(x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }

    public class TestStudent
    {
        //public static int CompareNames(Student S1, Student S2)
        //{
        //    return S1.Name.CompareTo(S2.Name);
        //}
        static void Main()
        {
            Student s1 = new Student { Sid = 103, Name = "Ajay", Class = 10, Marks = 575.00f };
            Student s2 = new Student { Sid = 106, Name = "Yash", Class = 10, Marks = 535.00f };
            Student s3 = new Student { Sid = 104, Name = "Will", Class = 10, Marks = 592.00f };
            Student s4 = new Student { Sid = 102, Name = "Mike", Class = 10, Marks = 453.00f };
            Student s5 = new Student { Sid = 101, Name = "Avni", Class = 10, Marks = 512.00f };
            Student s6 = new Student { Sid = 105, Name = "John", Class = 10, Marks = 498.00f };

            List<Student> Students = new List<Student>() { s1, s2, s3, s4, s5, s6 };
            //Students.Sort();  // Sort based on Sid

            //CompareStudents obj = new CompareStudents();
            //Students.Sort(obj);  // Sort based on Marks
            //Students.Sort(1, 5, obj);  // Sort a part of the list based on Marks

            //Comparison<Student> obj = new Comparison<Student>(CompareNames);
            //Students.Sort(obj);

            //Students.Sort(CompareNames);

            //Students.Sort(delegate(Student S1, Student S2)
            //{
            //    return S1.Name.CompareTo(S2.Name);
            //});

            Students.Sort((S1, S2) => S1.Name.CompareTo(S2.Name));

            //Students.Reverse();

            foreach (Student S in Students)
            {
                Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);
            }
        }
    }
}
