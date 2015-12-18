using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using VisitorPattern.application.customUI;

namespace VisitorPattern.application
{
    /// <summary>
    ///  Visits all Windows UI control elements that implement the appropriate IControlElement interface 
    /// </summary>
    interface IControlVisitor
    {
        void Visit(CustomButton textBlock);
        void Visit(CustomTextBox customTextBox); 
        void Visit(CustomLabel label); 
    }
}
