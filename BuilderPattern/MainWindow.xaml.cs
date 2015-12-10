using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls; 
using BuilderPattern.application; 

namespace BuilderPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             

            SignUpFormDirector director = new SignUpFormDirector();
            director.SetFormBuilder(new CateringCompanyFormBuilder());
            director.ConstructForm("Royal Catering Company Signup Form");
            director.AddSignupFormToGrid(grid1); 
            
        }
    }
}
