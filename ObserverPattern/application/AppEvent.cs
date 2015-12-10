using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.application
{
    /// <summary>
    /// Generic enumeration that is meant for demonstration. 
    /// This can be implemented or native Event enums 
    /// </summary>
    public enum AppEvent
    {
        CLICKED, 
        DOUBLE_CLICKED,
        USER_TYPING
    }
}
