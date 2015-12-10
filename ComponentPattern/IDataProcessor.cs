using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentPattern
{
    /// <summary>
    /// This interface represents the Component element of the Component design pattern.
    /// Both leaf and composite classes implements this 
    /// </summary>
    public interface IDataProcessor
    {
        /// <summary>
        /// Processes data found in file 
        /// </summary>
        /// <param name="columns">The columns of a CSV or other delimited style file.</param>
        string[] ProcessData(string[] columns); 
    }
}
