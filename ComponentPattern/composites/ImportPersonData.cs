using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentPattern.components;

namespace ComponentPattern.composites
{
    /// <summary>
    /// represents a concrete component of the Component design pattern. 
    /// This is responsible for utilizing input data and performing various 
    /// actions on the data via its contained components. 
    /// </summary>
    class ImportPersonData : CompositeDataProcessor
    {
        /// <summary>
        /// Add components 
        /// </summary>
        public ImportPersonData() : base()
        {
            this.AddComponent(new CapitalizeData());
            this.AddComponent(new PrintData()); 
        }

        
 
    }
}
