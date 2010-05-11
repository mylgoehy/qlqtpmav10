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
	public partial class uc_Listening : UserControl
	{
		public uc_Listening()
		{
			// Required to initialize variables
			InitializeComponent();
		}

        private void rctListening_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagListening)
                rctListening.Opacity = 0;
        }

        private void rctListening_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagListening)
                rctListening.Opacity = 0.5;
        }

        private void rctListening_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //rctListening.Opacity = 0.5;
            //rctSpeaking.Opacity = 0;
            ////rctReading.Opacity = 0;
            //rctLanguageFocus.Opacity = 0;
            //rctWriting.Opacity = 0;
            //flagListening = false;
            //flagSpeaking = true;
            //flagReading = true;
            //flagWriting = true;
            //flagLanguageFocus = true;
        }
	}
}