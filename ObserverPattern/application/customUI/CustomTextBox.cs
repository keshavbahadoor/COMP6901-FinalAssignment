using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using ObserverPattern;
using System.Windows;
using System.Windows.Input;

namespace ObserverPattern.application.customUI
{
    /// <summary>
    /// this is an example of a concrete Observable or Subject 
    /// </summary>
    class CustomTextBox : AbstractObservable
    {
        private TextBox textBox; 

        public CustomTextBox()
        {
            textBox = new TextBox(); 
            textBox.AddHandler(TextBox.MouseDoubleClickEvent, new RoutedEventHandler(HandleMouseDoubleClick));
            textBox.AddHandler(TextBox.TextChangedEvent, new RoutedEventHandler(HandleTextChanged));
            textBox.Text = "Double click on or type in me. One of my observers is the log box below."; 
        }

        /// <summary>
        /// Notify all observers of a double click event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleMouseDoubleClick(object sender, RoutedEventArgs e)
        {
            notifyAll(AppEvent.DOUBLE_CLICKED); 
        }

        /// <summary>
        /// Notify all observers when text is changed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleTextChanged(object sender, RoutedEventArgs e)
        {
            notifyAll(AppEvent.USER_TYPING); 
        }

        public TextBox GetControl()
        {
            return textBox; 
        }

    }
}
