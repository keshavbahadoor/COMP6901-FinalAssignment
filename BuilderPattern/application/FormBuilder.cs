using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BuilderPattern.application
{
    /// <summary>
    /// Represents the "Abstract builder" component of the Builder pattern implementation
    /// This class defines the method calls that are then used by child builders 
    /// to produce the required product. 
    /// </summary>
    public abstract class FormBuilder
    {
        protected SignUpForm form;

        /// <summary>
        /// inits new form and sets name 
        /// </summary>
        /// <param name="name"></param>
        public void CreateNewSignUpForm(string name)
        {
            form = new SignUpForm();
            form.Name = name; 
        }
        /// <summary>
        /// Defines the head or the top of the form. 
        /// </summary>
        public abstract void DesignHeading();

        public abstract void DesignPersonalInfo(); 

        public abstract void DesignContactInfo();

        public abstract void DesignSubmit();

        public abstract void DesignFooting(); 

        public SignUpForm GetForm()
        {
            return form; 
        }
       
    }
}
