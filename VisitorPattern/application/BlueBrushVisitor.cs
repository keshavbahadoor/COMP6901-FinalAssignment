using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.application.customUI;
using System.Windows.Media;

namespace VisitorPattern.application
{
    /// <summary>
    /// This visitor changes the color of the current GUI control to warn the user 
    /// </summary>
    class BlueBrushVisitor : IControlVisitor
    {
        public void Visit(CustomLabel label)
        {
            label.GetControl().Background = Brushes.LightBlue;
        }

        public void Visit(CustomTextBox customTextBox)
        {
            customTextBox.GetControl().Background = Brushes.LightBlue;
        }

        public void Visit(CustomButton button)
        {
            button.GetControl().Background = Brushes.LightBlue;
        }
    }
}
