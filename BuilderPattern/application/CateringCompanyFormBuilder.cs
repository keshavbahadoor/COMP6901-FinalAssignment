﻿using System;
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
            t.Visibility = System.Windows.Visibility.Collapsed;
            form.AddFormElement("Royal Catering Company Presents", t); 
        }

        public override void DesignContactInfo()
        {             
            form.AddFormElement("Email", new TextBox());
            form.AddFormElement("Mobile Number", new TextBox());
        }        
        
        public override void DesignPersonalInfo()
        {
            form.AddFormElement("First Name", new TextBox());
            form.AddFormElement("Last Name", new TextBox());
        }

        public override void DesignSubmit()
        {
            Button button = new Button();
            button.Content = "Submit";           
            form.AddFormElement("", button); 
        }

        public override void DesignFooting()
        {
            TextBox t = new TextBox();
            t.Visibility = System.Windows.Visibility.Collapsed; 
            form.AddFormElement("Thanks for your interest!", t);
        }

    }
}
