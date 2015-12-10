using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentPattern.components
{
    public class CapitalizeData : IDataProcessor
    {
        /// <summary>
        /// changes all values to uppercase 
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        public string[] ProcessData(string[] columns)
        {
            for (int i=0; i<columns.Length; i++)
            {
                columns[i] = columns[i].ToUpper(); 
            }
            return columns; 
        }
    }
}
