using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Collections;
using System.Windows.Controls;

namespace BuilderPattern.application
{
    /// <summary>
    /// This class represents the director component of the Builder design pattern 
    /// </summary>
    class SignUpFormDirector
    {
        private FormBuilder formBuilder; 

        /// <summary>
        /// Specifies the appropriate formbuilder child to use 
        /// </summary>
        /// <param name="specifiedFormBuilder"></param>
        public void SetFormBuilder(FormBuilder specifiedFormBuilder)
        {
            formBuilder = specifiedFormBuilder; 
        }

        public void ConstructForm(string name)
        {
            formBuilder.CreateNewSignUpForm(name);
            formBuilder.DesignHeading();
            formBuilder.DesignPersonalInfo();
            formBuilder.DesignContactInfo();
            formBuilder.DesignSubmit();
            formBuilder.DesignFooting();
        }

        public SignUpForm GetSignUpForm()
        {
            return formBuilder.GetForm(); 
        } 

        /// <summary>
        /// Uses the constructed form and appends each element to the grid 
        /// of the WPF application 
        /// </summary>
        /// <param name="grid"></param>
        public void AddSignupFormToGrid(Grid grid)
        {                                 
            SignUpForm form = formBuilder.GetForm(); 

            if (form != null && form.Size() > 0)
            {
                IEnumerator enumerator = form.GetEnumerator();
                int count = 0; 
                while (enumerator.MoveNext())
                {
                    FormElement element = (FormElement) enumerator.Current;

                    // Add label 
                    Label label = new Label();
                    label.Width = grid.Width;
                    label.Content = element.Label;
                    Grid.SetRow(label, count++);
                    grid.Children.Add(label);
                  
                    // Add form control 
                    element.Control.Width = grid.Width;
                    Grid.SetRow(element.Control, count++);
                    grid.Children.Add(element.Control);  
                }
            }
        }
    }
}
