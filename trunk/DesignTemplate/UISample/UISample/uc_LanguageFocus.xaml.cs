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
	public partial class uc_LanguageFocus : UserControl
	{
		public uc_LanguageFocus()
		{
			// Required to initialize variables
			InitializeComponent();
		}
       
        private void rctLanguageFocus_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagLanguageFocus)
                rctLanguageFocus.Opacity = 0;
        }

        private void rctLanguageFocus_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagLanguageFocus)
                rctLanguageFocus.Opacity = 0.5;
        }

        private void rctLanguageFocus_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //rctLanguageFocus.Opacity = 0.5;
            //rctWriting.Opacity = 0;
            //rctListening.Opacity = 0;
            //rctSpeaking.Opacity = 0;
            ////rctReading.Opacity = 0;
            //flagLanguageFocus = false;
            //flagWriting = true;
            //flagListening = true;
            //flagSpeaking = true;
            //flagReading = true;
        }
	}
}