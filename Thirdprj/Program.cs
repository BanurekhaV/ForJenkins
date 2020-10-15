using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondPrj;

namespace Thirdprj
{
    class OverloadEg
    {
        public static void swap(int n1, int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("Swapped Numbers" + " " + n1 + n2);
            Console.Read();
        }
        public static void swap(char c1, char c2)
        {
            char temp;
            temp = c1;
            c1 = c2;
            c2 = temp;
            Console.WriteLine("Swapped Numbers" +" "+ c1 + c2);
            Console.Read();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
            // s.DisplayStudent();
            OverloadEg.swap(2, 8);
            OverloadEg.swap('a', 'b');
            Console.Read();
        }
    }
}
