using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentPattern; 

namespace ComponentPattern
{
    /// <summary>
    /// This class represents the Composite part of the Component design pattern 
    /// </summary>
    public abstract class CompositeDataProcessor : IDataProcessor
    {
        // list of components 
        private List<IDataProcessor> components; 

        /// <summary>
        /// Constructor 
        /// </summary>
        public CompositeDataProcessor()
        {
            components = new List<IDataProcessor>();
        }

        /// <summary>
        /// Each component that is contained in the composite is called to process data 
        /// This is the beauty of the component design pattern. 
        /// </summary>
        /// <param name="columns"></param>
        public string[] ProcessData(string[] columns)
        {
            for (int i=0; i<components.Count; i++)
            {
                columns = components[i].ProcessData(columns); 
            }             
            return columns; 
        }

        /// <summary>
        /// Adds to component collection 
        /// </summary>
        /// <param name="component"></param>
        public void AddComponent(IDataProcessor component)
        {
            components.Add(component); 
        }

        /// <summary>
        /// Removes component from collection 
        /// </summary>
        /// <param name="component"></param>
        public void RemoveComponent(IDataProcessor component)
        {
            components.Remove(component); 
        }

        /// <summary>
        /// Removes component from collection by index 
        /// </summary>
        /// <param name="index"></param>
        public void RemoveComponent(int index)
        {
            if (index >= 0 && index < components.Count)
            {
                components.RemoveAt(index);
            }            
        }
         
    }
}
