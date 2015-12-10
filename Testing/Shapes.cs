using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public abstract class Shape 
    {
        public virtual void Draw()
        {
            Console.WriteLine("This is a shape"); 
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("This is a Circle");
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("This is a Square");
        }
    }

    public static class ShapeFactory
    {
        public static Shape GetShape(string name)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetType(name).FullName;
            Shape shape = (Shape)Activator.CreateInstanceFrom(assembly.Location, type).Unwrap();

            return shape;
        }
    }
}
