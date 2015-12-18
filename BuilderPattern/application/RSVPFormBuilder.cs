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
    class RSVPFormBuilder : FormBuilder
    {
        public override void DesignHeading()
        {
            TextBox t = new TextBox();
            t.Visibility = System.Windows.Visibility.Collapsed;
            form.AddFormElement("Please RSVP to the event below.", t);
        }

        public override void DesignContactInfo()
        {
            form.AddFormElement("Email", new TextBox()); 
        }

        public override void DesignPersonalInfo()
        {
            form.AddFormElement("Name", new TextBox());
            form.AddFormElement("Name of your guest", new TextBox());
        }

        public override void DesignSubmit()
        {
            Button button = new Button();
            button.Content = "RSVP";
            form.AddFormElement("", button);
        }

        public override void DesignFooting()
        {
            TextBox t = new TextBox();
            t.Visibility = System.Windows.Visibility.Collapsed;
            form.AddFormElement("Hope to see you there!", t);
        }
    }
}
