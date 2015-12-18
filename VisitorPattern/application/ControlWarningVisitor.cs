using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using VisitorPattern.application.customUI;
using System.Windows.Media; 

namespace VisitorPattern.application
{
    /// <summary>
    /// This visitor changes the color of the current GUI control to warn the user 
    /// </summary>
    class ControlWarningVisitor : IControlVisitor
    {
        public void Visit(Button button)
        {
            throw new NotImplementedException();
        }

        public void Visit(Label label)
        {
            throw new NotImplementedException();
        }

        public void Visit(CustomTextBox customTextBox)
        {
            customTextBox.GetControl().Background = Brushes.LightPink; 
        }

        public void Visit(TextBlock textBlock)
        {
            throw new NotImplementedException();
        }
    }
}
