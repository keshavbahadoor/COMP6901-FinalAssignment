using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace COMP6901_FinalAssignment.application
{
    public interface IShapeFactory
    {
        Shape GetShape(string shapeName, int height, int width, string fillColorName, string strokeColorName); 
    }
}
