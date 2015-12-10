using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ObserverPattern.application;
using ObserverPattern.application.customUI; 

namespace ObserverPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {           
            // .NET init  
            InitializeComponent();

            // Init application 
            LogBox.IsReadOnly = true;
            SimpleLogService logService = new SimpleLogService(LogBox);
            logService.Log("Started");

            // Add custom text box (This is an Observerable / subject) 
            CustomTextBox customTextBox = new CustomTextBox();
            customTextBox.GetControl().Width = ElementGrid.Width / 2;
            Grid.SetRow(customTextBox.GetControl(), 1);
            ElementGrid.Children.Add(customTextBox.GetControl());

            // Connect observers 
            customTextBox.RegisterObserver(logService); 
        }
    }
}
