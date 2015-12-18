using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Collections; 

namespace VisitorPattern.application.customUI
{
    /// <summary>
    /// Complex IControlElement structure 
    /// </summary>
    class CustomGridElement : IControlElement
    {
        private Grid grid;
        private List<IControlElement> elements;
        private readonly int COLUMNS = 2;
        private readonly int ROWS = 4;

        /// <summary>
        /// init isntance variables 
        /// adds columns and rows to grid 
        /// </summary>
        /// <param name="grid"></param>
        public CustomGridElement(Grid grid)
        {
            this.grid = grid;
            elements = new List<IControlElement>();

            for (int i = 0; i <= COLUMNS; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i <= ROWS; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }

            elements.Add(new CustomTextBox());
            elements.Add(new CustomTextBox());
            elements.Add(new CustomLabel("I am a label"));
            elements.Add(new CustomTextBox());
            elements.Add(new CustomTextBox());
            PopulateGrid(); 
        }

        /// <summary>
        /// Populates the grid with elements 
        /// </summary>
        private void PopulateGrid()
        {
            int row = 0;
            int column = 0; 
            for (int i=0; i<elements.Count; i++)
            {
                IControlElement element = elements[i];
                element.GetControl().Width = grid.Width / 2;
                element.GetControl().Height = grid.Height / 16;
                Grid.SetColumn(element.GetControl(), column);
                Grid.SetRow(element.GetControl(), row);
                grid.Children.Add(element.GetControl());

                row++;
                column++; 
                if (column == COLUMNS)
                {
                    column = 0; 
                }            
            }            
        }

        /// <summary>
        /// Each child element is passed the visitor object. 
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IControlVisitor visitor)
        {
            for (int i=0; i<elements.Count; i++)
            {
                elements[i].Accept(visitor); 
            }
        }

        public Control GetControl()
        {
            throw new NotImplementedException();
        }
    }
}
