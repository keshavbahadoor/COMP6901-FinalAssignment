using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BuilderPattern.application
{
    /// <summary>
    /// This class represents an example of a concrete builder that showcases the 
    /// Builder design pattern. 
    /// </summary>
    class CateringCompanyFormBuilder : FormBuilder
    {
        public override void DesignHeading()
        {
            TextBox t = new TextBox();
            t.Text = "We are pleased to fit every occasion.";
            form.AddFormElement("Royal Catering Company Presents", t); 
        }

        public override void DesignContactInfo()
        {
                                    
          
        }        
        
        public override void DesignPersonalInfo()
        {
             
        }

        public override void DesignSubmit()
        {
             
        }

        public override void DesignFooting()
        {

        }

    }
}
