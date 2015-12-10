using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentPattern.components;
using ComponentPattern.composites; 


namespace ComponentPattern
{
    /// <summary>
    /// This project demonstrates the Component design pattern by presenting a delimited file reader example. 
    /// The component pattern is used to modularize various operations that can be performed on the file data 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application Start");
            {
                IDataProcessor dataProcessor = new ImportPersonData(); 

                FileProcessor processor = new FileProcessor(dataProcessor);
                processor.FileExtension = "csv";
                processor.FileDelimiter = ","; 
                processor.ProcessDirectory(Properties.Settings.Default.FILE_DIRECTORY); 
            }
            Console.WriteLine("Application End. Press any key to continue.");
            Console.ReadLine(); 
        }

         
    }
}
