using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VisitorPattern.application.customUI
{
    class CustomButton : IControlElement
    {
        private Button button;

        /// <summary>
        /// constructor 
        /// </summary>
        public CustomButton( )
        {
            button = new Button(); 
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
            return button;
        }
    }
}
