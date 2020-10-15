using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Thirdprj
{
    class Shape
    {
        protected float R, L, B;

        public virtual float Area()
        {
            return 3.14f * R * R;
        }
        public virtual float Circumference()
        {
            return 2 * 3.14f * R;
        }
    }

    class Rectangle:Shape
    {
        public void GetLB()
        {
            Console.WriteLine("Enter Length and Breadth");
            L = float.Parse(Console.ReadLine());
            B = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
           // base.Area();
            return L * B;
        }
        public override float Circumference()
        {
            // return base.Circumference();
            return 2 * (L + B);
        }

    }

    class Circle:Shape
    {
        public void GetRadius()
        {
            Console.WriteLine("Enter Radius");
            R = float.Parse(Console.ReadLine());

        }
    }
    class VirtualOverrideEg
    {
        public static void Main()
        {
           // Shape s = new Rectangle();
            Rectangle R = new Rectangle();
            R.GetLB();
            Console.WriteLine("Area :{0}", R.Area());
            Console.WriteLine("Circunference :{0}", R.Circumference());
            Console.WriteLine();
            Circle c = new Circle();
            c.GetRadius();
            Console.WriteLine("Area :{0}", c.Area());
            Console.WriteLine("Circunference :{0}", c.Circumference());
            Console.Read();
        }
    }
}
