using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thirdprj
{
    class Box
    {
        public int Length;
        public int Breadth;

        public static Box operator +(Box B1, Box B2)
        {
            Box Result = new Box();
            Result.Length = B1.Length + B2.Length;
            Result.Breadth = B1.Breadth + B2.Breadth;
            return Result;
        }

    }
    class OperatorOverloadEg
    {
        public static void Main()
        {
            Box big = new Box();
            big.Length = 5;
            big.Breadth = 4;
            Box small = new Box();
            small.Length = 2;
            small.Breadth = 3;
            Box total = new Box();
            total = big + small;
            Console.WriteLine("The overall size of the box is {0}{1}", total.Length, total.Breadth);
            Console.Read();
        }
    }
}
