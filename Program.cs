using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Shape>();

            list.Add(new Rectangle(10, 14));
            list.Add(new Circle(8));
            list.Add(new Triangle(10, 9));



            Console.WriteLine($"Area of Rectangle: {list[0].CalculateSurface()}");
            Console.WriteLine($"Area of Circle: {list[1].CalculateSurface()}");
            Console.WriteLine($"Area of Triangle: {list[2].CalculateSurface()}");
            Console.ReadKey();



        }
    }
}
