using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thirdprj
{
    class Base
    {
       public int Data;

        public Base(int x)
        {
            Data = x;
            Console.WriteLine("Base Here" );
            Console.Read();
        }
        public void Method1(string s)
        {
            Console.WriteLine(s);
        }
        ~Base()
        {
            Console.WriteLine("Bye from Base");
            Console.Read();
        }
    }

    class child :Base
    {
       new int Data; // this Data hides the Data in Base Class

        public child(int a, int b):base(b)
        {
            Data = a;
            Console.WriteLine(base.Data);
            Console.WriteLine("Child Here" + Data);
            Console.Read();
        }

        public new void Method1(string str) //method hiding
        {
            base.Method1("Hello Base");
            Console.WriteLine("Message from child" + str);
        }
        public void Getdata()
        {
            Console.WriteLine(base.Data);
        }
        ~child()
        {
            Console.WriteLine("Bye from Child");
            Console.Read();
        }
    }
    class BaseDerived
    {
        static void Main()
        {
            child c = new child(2, 5);
            c.Data = 20;
            c.Method1("Hai Child");
            Console.Read();
        }
    }
}
