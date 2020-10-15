using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPrj
{
    class Employee
    {
        int Empid;
        string Name;
        float Salary;
       // DateTime DOJ;

     internal Employee()
        {
            Empid = 101;
            Name = "Raja";
            Salary = 25000.67f;
           // DOJ = "01/01/1990";
        }

        public Employee(int e, string Name, float Sal)
        {
            Empid = e;
            this.Name = Name;
            Salary = Sal;

        }
        public void ShowEmployee()
        {
            Console.WriteLine("Emp Id is :{0}  EmpName is :{1}, and Salary is :{2}", Empid, Name, Salary);
            Console.Read();
        }
       ~Employee()
        {
            Console.WriteLine("Bye from Employee");
            Console.Read();
        }

    }

    class TestEmployee
    {
        public static void Main()
        {
            Employee e = new Employee();
            e.ShowEmployee();
            Employee emp = new Employee(200, "Murali", 30000.56f);
            emp.ShowEmployee();
            Student stud = new Student();
            stud.Rollno = 100;
            stud.Name = "Roja";
            stud.DisplayStudent();
            Console.Read();
        }
    }
}
