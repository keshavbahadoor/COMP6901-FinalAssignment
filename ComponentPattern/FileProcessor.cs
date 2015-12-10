using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.IO; 

namespace ComponentPattern
{
    public class FileProcessor
    {
        private IDataProcessor dataProcessor;
        public string FileExtension { get; set; }
        public string FileDelimiter { get; set; }

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="processor"></param>
        public FileProcessor(IDataProcessor processor)
        {
            dataProcessor = processor;
            FileExtension = "csv";
            FileDelimiter = ",";
        }

        /// <summary>
        /// Iterates through the default directory and processes each file in turn 
        /// </summary>
        /// <param name="directory"></param>
        public void ProcessDirectory(string directory)
        {
            if (Directory.Exists(directory))
            {
                foreach (string file in Directory.EnumerateFiles(directory, @"*." + FileExtension))
                {
                    ProcessFile(file);  
                }
            }
            else
            {
                Console.WriteLine("ERROR!: Directory does not exist: " + directory);
                Console.WriteLine("Aborting..."); 
            }
        }

        /// <summary>
        /// Processes all files given the filename and path 
        /// </summary>
        /// <param name="file"></param>
        public void ProcessFile(string file)
        {
            try
            {
                Console.WriteLine("Starting file processing");
                {
                    using (TextFieldParser parser = new TextFieldParser(file))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(FileDelimiter);
                        while (!parser.EndOfData)
                        {
                            //Processing row
                            string[] fields = parser.ReadFields();
                            dataProcessor.ProcessData(fields);
                        }
                    }
                }
                Console.WriteLine("File processing completed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured!");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
 
    }
}
