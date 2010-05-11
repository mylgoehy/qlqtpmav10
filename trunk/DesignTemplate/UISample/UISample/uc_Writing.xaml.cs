using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace UISample
{
	public partial class uc_Writing : UserControl
	{
        bool flagReading = true;
        bool flagListening = true;
        bool flagSpeaking = true;
        bool flagWriting = true;
        bool flagLanguageFocus = true;

		public uc_Writing()
		{
			// Required to initialize variables
			InitializeComponent();
		}
        
        private void rctWriting_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagWriting)
                rctWriting.Opacity = 0;
        }

        private void rctWriting_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagWriting)
                rctWriting.Opacity = 0.5;
        }

        private void rctWriting_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //rctWriting.Opacity = 0.5;
            //rctListening.Opacity = 0;
            //rctSpeaking.Opacity = 0;
            ////rctReading.Opacity = 0;
            //rctLanguageFocus.Opacity= 0;
            //flagWriting = false;
            //flagListening = true;
            //flagSpeaking = true;
            //flagReading = true;
            //flagLanguageFocus = true;
        }
	}
}