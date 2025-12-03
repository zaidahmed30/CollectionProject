using System;
using System.Collections.Generic;
using System.Collections;

namespace CollectionProject
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }
    public class Organization : IEnumerable
    {
        List<Employee> Emps = new List<Employee>();
        public void Add(Employee Emp)
        {
            Emps.Add(Emp);
        }
        public int Count
        {
            get { return Emps.Count; }
        }
        public Employee this[int index]
        {
            get { return Emps[index]; }
        }
        public IEnumerator GetEnumerator()
        {
            //return Emps.GetEnumerator();
            return new OrganizationEnumerator(this);
        }
    }
    public class OrganizationEnumerator : IEnumerator
    {
        Organization OrgColl;
        int CurrentIndex;
        Employee CurrentEmployee;

        public OrganizationEnumerator(Organization org)
        {
            OrgColl = org;
            CurrentIndex = -1;
        }
        public object Current
        {
            get
            {
                return CurrentEmployee;
            }
        }

        public bool MoveNext()
        {
            if(++CurrentIndex >= OrgColl.Count)
                return false;
            else
                CurrentEmployee = OrgColl[CurrentIndex];
            return true;
        }

        public void Reset()
        {
        }
    }
    public class TestEmployee
    {
        static void Main()
        {
            //List<Employee> Employees = new List<Employee>();
            Organization Employees = new Organization();
            Employees.Add(new Employee { Id = 101, Name = "Mike", Job = "Manager", Salary = 25000.00 });
            Employees.Add(new Employee { Id = 102, Name = "Will", Job = "Analyst", Salary = 20000.00 });
            Employees.Add(new Employee { Id = 103, Name = "Jane", Job = "Sales", Salary = 15000.00 });
            Employees.Add(new Employee { Id = 104, Name = "Iqra", Job = "Sales", Salary = 15000.00 });
            Employees.Add(new Employee { Id = 105, Name = "Anya", Job = "Sales", Salary = 15000.00 });
            Employees.Add(new Employee { Id = 106, Name = "Raju", Job = "Clerk", Salary = 5000.00 });

            foreach(Employee Emp in Employees)
            {
                Console.WriteLine(Emp.Id + " " + Emp.Name + " " + Emp.Job + " " + Emp.Salary);
            }
        }
    }
}
