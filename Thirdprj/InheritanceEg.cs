using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thirdprj
{
    class Student
    {
        private string rollno;
        private string name;
        private string cls;

        public void GetStudentData()
        {
            Console.WriteLine("Enter RollNo");
            rollno = Console.ReadLine();
            Console.WriteLine("Enter Name and Class");
            name = Console.ReadLine();
            cls = Console.ReadLine();
        }

        public void PutStudentData()
        {
            Console.WriteLine("Rollno ={0} Name ={1} and Class ={2}", rollno, name, cls);
            Console.Read();
        }
    }

    class Marks:Student
    {
        protected int[] s = new int[5];

        public void GetMarks()
        {
            for(int i=0; i<s.Length;i++)
                {
                Console.WriteLine("Enter Subject{0} Marks", i + 1);
                s[i] = Convert.ToInt32(Console.ReadLine());

                }
        }
        public void PutMarks()
        {
            for(int i=0;i<s.Length;i++)
            {
                Console.WriteLine("Marks in Subject{0} is {1}", i + 1, s[i]);
            }
        }
    }

    class Results:Marks
    {
        int TotalMarks = 0;

        public void GetResult()
        {
            for(int i=0; i<s.Length;i++)
            {
                TotalMarks = TotalMarks + s[i];
            }
            Console.WriteLine("Aggregate Marks ={0}", TotalMarks);
        }
    }
    class InheritanceEg
    {
        static void Main()
        {
            Results r = new Results();
            r.GetStudentData();
            r.GetMarks();
            r.GetResult();
            Console.Read();
        }
    }
}
