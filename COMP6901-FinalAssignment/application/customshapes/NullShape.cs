using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Composition;
using System.Windows.Shapes;

namespace COMP6901_FinalAssignment.application
{
    public class NullShape : Shape
    {
        protected override Geometry DefiningGeometry
        {
            get
            {
                return null; 
            }
        }
    }
}
