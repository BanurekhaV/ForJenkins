using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPrj
{
   public class Student
    {
       internal int Rollno;
      public string Name;

        public void DisplayStudent()
        {
            Console.WriteLine("RollNo ={0}, Name={1}",Rollno, Name);
            Console.Read();
        }
    }
    class Accessspecifierseg
    {
        public static void Main()
        {
            int x, y;
            x = 10; y = 11;
            Student s = new Student();
            s.Rollno = 10;
            s.Name = "Aradhana";
            s.DisplayStudent();
        }
    }
}
