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
using COMP6901_FinalAssignment.application;
using System.Reflection; 

namespace COMP6901_FinalAssignment
{    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Instance of factory 
        /// </summary>
        private ShapeFactory shapeFactory; 

        public MainWindow()
        {
            InitializeComponent();
            InitColorComboBoxes();
            shapeFactory = new ShapeFactory(); 
        }

        /// <summary>
        /// Handles mouse down button events. 
        /// Creates a specified shape at the point of mouse clicks
        /// Notes: 
        ///     Mouse down coordinates not yet refined. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Canvas_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                int height, width; 

                if (!int.TryParse(tbHeight.Text, out height) ||
                    !int.TryParse(tbWidth.Text, out width))
                {
                    MessageBox.Show("Height or width must be numeric.");
                    return;
                }              

                Shape shape = (Shape) shapeFactory.CreateSystemShape(shapeType.Text, height, width,  colorComboBox.Text, "Black");                
                Canvas.Children.Add(shape); 
                Canvas.SetTop(shape, Mouse.GetPosition(Canvas).Y);
                Canvas.SetLeft(shape, Mouse.GetPosition(Canvas).X);                 
            }                
        }
        /// <summary>
        /// Gets system color available from WPF and adds to the combobox 
        /// </summary>
        private void InitColorComboBoxes()
        {
            Type colorType = typeof(System.Drawing.Color);
            // filter properties here
            PropertyInfo[] propInfos = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo propInfo in propInfos)
            {
                Console.WriteLine(propInfo.Name);
                colorComboBox.Items.Add(propInfo.Name); 
            }
            colorComboBox.SelectedItem = "Red"; 
        }

 
    }

    
}
