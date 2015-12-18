using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VisitorPattern.application;
using VisitorPattern.application.customUI; 

namespace VisitorPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // init elements 
            IControlElement customTextBox = new CustomTextBox();
            customTextBox.GetControl().Width = ElementGrid.Width / 2;
            Grid.SetRow(customTextBox.GetControl(), 1);
            ElementGrid.Children.Add(customTextBox.GetControl());

            // init visitors 
            IControlVisitor controlWarningVisitor = new ControlWarningVisitor();

            // visit 
            customTextBox.Accept(controlWarningVisitor); 
        }
    }
}
