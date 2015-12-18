using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VisitorPattern.application.customUI
{
    class CustomLabel : IControlElement
    {
        private Label label;

        /// <summary>
        /// constructor 
        /// </summary>
        public CustomLabel(string text)
        {
            label = new Label();
            label.Content = text; 
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
            return label;
        }
    }
}
