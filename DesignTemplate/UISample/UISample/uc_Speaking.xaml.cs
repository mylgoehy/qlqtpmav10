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
	public partial class uc_Speaking : UserControl
	{
		public uc_Speaking()
		{
			// Required to initialize variables
			InitializeComponent();
		}
        
        private void rctSpeaking_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagSpeaking)
                rctSpeaking.Opacity = 0;
        }

        private void rctSpeaking_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagSpeaking)
                rctSpeaking.Opacity = 0.5;
        }

        private void rctSpeaking_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //rctSpeaking.Opacity = 0.5;
            //rctReading.Opacity = 0;
            //rctListening.Opacity = 0;
            //rctLanguageFocus.Opacity = 0;
            //rctWriting.Opacity = 0;
            //flagSpeaking = false;
            //flagReading = true;
            //flagListening = true;
            //flagWriting = true;
            //flagLanguageFocus = true;
        }
	}
}