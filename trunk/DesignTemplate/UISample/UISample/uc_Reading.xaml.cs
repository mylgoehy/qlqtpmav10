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
	public partial class uc_Reading : UserControl
	{
		public uc_Reading()
		{
			// Required to initialize variables
			InitializeComponent();
		}

        private void rctReading_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagReading)
                rctReading.Opacity = 0;
        }

        private void rctReading_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagReading)
                rctReading.Opacity = 0.5;
        }

        private void rctReading_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //rctReading.Opacity = 0.5;
            //rctSpeaking.Opacity = 0;
            //rctListening.Opacity = 0;
            //rctLanguageFocus.Opacity = 0;
            //rctWriting.Opacity = 0;
            //flagReading = false;
            //flagListening = true;
            //flagWriting = true;
            //flagLanguageFocus = true;
            //flagSpeaking = true;
            //cnvReading.Opacity = 100;

            Storyboard sb = (this.Resources["strbShowReadingContent"] as Storyboard);
            sb.Begin();
            //sao lai ko chay dc vay :((
        }
	}
}