using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reflection test");

            Shape shape = ShapeFactory.GetShape("Circle");
            shape.Draw();
             
            Console.ReadLine(); 
            Console.WriteLine("Finished"); 
        }
    }
}
