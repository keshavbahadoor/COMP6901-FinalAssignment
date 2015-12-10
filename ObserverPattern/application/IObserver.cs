using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.application;

namespace ObserverPattern.application
{
    /// <summary>
    /// Observer aspect of the Observer design patterns
    /// Note that in an actual .NET application, I would generally just use the 
    /// default IObserver interface that is part of .NET. This is for demonstration.  
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Called when the subject notifies its observers 
        /// </summary>
        /// <param name="state">State of the application / UI</param>
        void onNotify(AppEvent state); 
    }
}
