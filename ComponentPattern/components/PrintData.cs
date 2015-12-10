using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentPattern.components
{
    public class PrintData : IDataProcessor
    {
        /// <summary>
        /// outputs to screen 
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        public string[] ProcessData(string[] columns)
        {
            for (int i = 0; i < columns.Length; i++)
            {
                Console.WriteLine(columns[i]); 
            }
            return columns;
        }
    }
}
