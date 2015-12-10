using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace COMP6901_FinalAssignment.application
{
    /// <summary>
    /// This is an implementation of the Simple Factory design pattern 
    /// </summary>
    public class ShapeFactory
    {
        public static readonly int DEFAULT_STROKE_THICKNESS = 1;
        private List<Shape> instantiatedElements; 

        /// <summary>
        /// Constructor 
        /// </summary>
        public ShapeFactory()
        {
            instantiatedElements = new List<Shape>(); 
        }

        /// <summary>
        /// Creates a new specified Shape object using (custom implemention of) Reflection.  
        /// Shape object created is direct child of System.Windows.Shapes assembly 
        /// Notes: 
        ///     - Usual C# reflection implementation cannot be done when instantiating child objects 
        ///       of certain System classes. This is because the full name of the assembly is required 
        ///       for resolving the type. 
        /// </summary>
        /// <param name="shapeName">The name of the subclass of Shape class to implement.</param>
        /// <param name="height">Height of the shape</param>
        /// <param name="width">Width of th shape</param>
        /// <param name="fillColor">The inside color of the shape</param>
        /// <param name="strokeColor">The border or outer color of the shape</param>
        /// <returns>intialized shape object</returns>
        public Shape GetSystemShape(string shapeName, int height, int width, string fillColorName, string strokeColorName)
        {
            try
            {
                string library = string.Format("System.Windows.Shapes.{0}", shapeName);
                Type typeToInitialize = typeof(Shape).Assembly.GetType(library, true); 
                Shape shape = (Shape)Activator.CreateInstance(typeToInitialize);

                var fillColor = (Color)ColorConverter.ConvertFromString(fillColorName);
                var strokeColor = (Color)ColorConverter.ConvertFromString(strokeColorName);

                SolidColorBrush fillBrush = new SolidColorBrush() { Color = fillColor };
                SolidColorBrush strokeBrush = new SolidColorBrush() { Color = strokeColor };

                shape.StrokeThickness = DEFAULT_STROKE_THICKNESS;
                shape.Fill = fillBrush;
                shape.Stroke = strokeBrush;
                shape.Width = width;
                shape.Height = height;

                instantiatedElements.Add(shape); 
                return shape;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine(e.StackTrace);
                return new NullShape();
            }
        }

        /// <summary>
        /// Creates a new specified custom shape object. Uses reflection during object creation. 
        /// </summary>
        /// <param name="shapeName">The name of the subclass of Shape class to implement.</param>
        /// <param name="height">Height of the shape</param>
        /// <param name="width">Width of th shape</param>
        /// <param name="fillColor">The inside color of the shape</param>
        /// <param name="strokeColor">The border or outer color of the shape</param>
        /// <returns>intialized custom shape object</returns>
        public Shape GetCustomShape(string shapeName, int height, int width, string fillColorName, string strokeColorName)
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                var type = assembly.GetType("COMP6901_FinalAssignment.application.CustomShapes.Triangle").FullName;
                Shape shape = (Shape)Activator.CreateInstanceFrom(assembly.Location, type).Unwrap();

                var fillColor = (Color)ColorConverter.ConvertFromString(fillColorName);
                var strokeColor = (Color)ColorConverter.ConvertFromString(strokeColorName);

                SolidColorBrush fillBrush = new SolidColorBrush() { Color = fillColor };
                SolidColorBrush strokeBrush = new SolidColorBrush() { Color = strokeColor };

                shape.StrokeThickness = DEFAULT_STROKE_THICKNESS;
                shape.Fill = fillBrush;
                shape.Stroke = strokeBrush;
                shape.Width = width;
                shape.Height = height; 

                instantiatedElements.Add(shape);
                return shape;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine(e.StackTrace);
                return new NullShape();
            }
        }
    }
}
