using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace VisitorPattern.application
{
    /// <summary>
    /// declares the visit operations for all the types of visitable classes of IControlVisitor
    /// </summary>
    interface IControlElement
    {
        /// <summary>
        /// Accepts a visitor object 
        /// </summary>
        /// <param name="visitor"></param>
        void Accept(IControlVisitor visitor); 

        /// <summary>
        /// returns the embedded windows media control 
        /// </summary>
        Control GetControl(); 
    }
}
