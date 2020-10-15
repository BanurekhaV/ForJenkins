using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method Parameter with Value types and reference type
            /* int i = 100;
             Program p = new Program();
             p.SimpleMethod(ref i);
             Console.WriteLine(i);*/
            int tot = 0;
            // int product = 0;
            // Calculate(10, out tot, out product,6);
            // Console.WriteLine("Sum is :{0} and Product is {1}", tot, product);
          tot=AddElements("hi");
            Console.WriteLine(tot);
            Console.Read();
        }
      public void SimpleMethod(ref int x) //instance method
        {
            x = 10;
        }

        public static void Calculate(int a, out int sum, out int prod, int b)
        {
            sum = a + b;
            prod = a * b;
        }
        public static int AddElements(string p, params int[] arr)  //Parameter Array
        {
            int sum = 0;
            Console.WriteLine(p);
            foreach (var x in arr)
            {
                sum += x;
                
            }
            Console.Read();
            return sum;
        }
    }

}
