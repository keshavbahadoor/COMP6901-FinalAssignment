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
        private IControlVisitor redBrushVisitor;
        private IControlVisitor blueBrushVisitor;
        private CustomGridElement grid; 

        public MainWindow()
        {
            InitializeComponent();

            grid = new CustomGridElement(ElementGrid);

            // init visitors 
            redBrushVisitor = new RedBrushVisitor();
            blueBrushVisitor = new BlueBrushVisitor(); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void redbutton_Click(object sender, RoutedEventArgs e)
        {
            grid.Accept(redBrushVisitor);
        }

        private void bluebutton_Click(object sender, RoutedEventArgs e)
        {
            grid.Accept(blueBrushVisitor);
        }
    }
}
