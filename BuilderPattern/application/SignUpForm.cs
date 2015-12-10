using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BuilderPattern.application
{
    /// <summary>
    /// Represents a label and GUI from control as one unit. 
    /// </summary>
    public struct FormElement
    {
        public string Label;
        public Control Control; 
    }
    /// <summary>
    /// This is the "Product" of the Builder pattern implementation. 
    /// A SignUpForm represents a defined form that can be used in 
    /// WPF applications for various needs. 
    /// </summary>
    public class SignUpForm : IEnumerable<FormElement>
    {
        public string Name { get; set; }
        private int currentPosition;
        private List<FormElement> formElements; 

        /// <summary>
        /// Init instance variables 
        /// </summary>
        public SignUpForm()
        {
            formElements = new List<FormElement>(); 
            currentPosition = 0; 
        }

        /// <summary>
        /// Adds a new form element 
        /// </summary>
        /// <param name="label"></param>
        /// <param name="element"></param>
        public void AddFormElement(string label, Control element)
        {
            formElements.Add(new FormElement()
                { Label = label,
                  Control = element
                });
        }
        /// <summary>
        /// increments counter, returns true if there are elements left to iterate, 
        /// false if otherwise. 
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            currentPosition++;
            return (currentPosition < formElements.Count);
        }

        public FormElement Current()
        {
            return formElements[currentPosition];
        }

        public IEnumerator<FormElement> GetEnumerator()
        {
            return formElements.GetEnumerator(); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            if (formElements == null)
                return 0;
            return formElements.Count; 
        }
    }
}
