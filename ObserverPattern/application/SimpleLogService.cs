using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Documents;
using ObserverPattern.application;

namespace ObserverPattern
{
    /// <summary>
    /// This is an example of a Concrete observer
    /// </summary>
    public class SimpleLogService : IObserver
    {
        private RichTextBox log;
         
        /// <summary>
        /// constructor 
        /// </summary>
        /// <param name="box"></param>
        public SimpleLogService(RichTextBox box)
        {
            log = box;
            log.Document.Blocks.Clear(); 
        }

        /// <summary>
        /// Logs to textbox element 
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        { 
            log.AppendText(DateTime.Now.ToString("yyyy-MM-dd:HHmmss") + " : " , "Silver");
            log.AppendText(message + System.Environment.NewLine, "DarkBlue");            
        }

        /// <summary>
        /// on notification, the Observer can chose to do whatever logic with regards to the type of event 
        /// </summary>
        /// <param name="state"></param>
        public void onNotify(AppEvent state)
        {
            switch (state)
            {
                case AppEvent.CLICKED:
                    Log("A CLICKED event was received in SimpleLogService");
                    break;
                case AppEvent.DOUBLE_CLICKED:
                    Log("A DOUBLE_CLICKED event was received in SimpleLogService");
                    break;
                case AppEvent.USER_TYPING:
                    Log("A USER_TYPING event was received in SimpleLogService");
                    break; 
            } 
            log.ScrollToEnd(); 
        }
    }
}
