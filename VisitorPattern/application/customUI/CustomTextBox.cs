using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VisitorPattern.application.customUI
{
    class CustomTextBox : IControlElement
    {
        private TextBox textBox; 

        /// <summary>
        /// constructor 
        /// </summary>
        public CustomTextBox()
        {
            textBox = new TextBox();
        }

        /// <summary>
        /// changes the text color accordingly 
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IControlVisitor visitor)
        {
            visitor.Visit(this); 
        }

        /// <summary>
        /// Returns contained textbox 
        /// </summary>
        /// <returns></returns>
        public Control GetControl()
        {
            return textBox;
        }
    }
}
