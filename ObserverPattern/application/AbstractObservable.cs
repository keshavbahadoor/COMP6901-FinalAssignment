using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.application; 

namespace ObserverPattern.application
{
    /// <summary>
    /// This is the subject or observable of the Observer design pattern. 
    /// Depending on the application or context, this component can either be 
    /// an Abstract Class or an Interface. I choose to implement this pattern 
    /// as an Abstract Class because it usually results in cleaner implementations 
    /// </summary>
    public abstract class AbstractObservable
    {
        /// <summary>
        /// List of observers that observes this subject 
        /// </summary>
        private List<IObserver> observers; 

        /// <summary>
        /// Constructor 
        /// </summary>
        public AbstractObservable()
        {
            observers = new List<IObserver>();
        }

        /// <summary>
        /// adds an observer to this subject 
        /// </summary>
        /// <param name="observer"></param>
        public void RegisterObserver(IObserver observer)
        {
            if (observers != null)
                observers.Add(observer); 
        }

        /// <summary>
        /// Removes an observer from this subject 
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(IObserver observer)
        {
            if (observers != null)
                observers.Remove(observer); 
        }

        /// <summary>
        /// Dumps all observers 
        /// </summary>
        public void RemoveAllObservers()
        {
            if (observers != null)
                observers.Clear(); 
        }

        /// <summary>
        /// Iterates through all the observers of this subject and 
        /// notifies each one 
        /// </summary>
        /// <param name="e">Current application status or event</param>
        public void notifyAll(AppEvent e)
        {
            for (int i=0; i<observers.Count; i++)
            {
                observers[i].onNotify(e); 
            }
        }


    }
}
