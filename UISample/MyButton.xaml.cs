using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace UISample
{
    public partial class MyButton : UserControl
    {
        public MyButton()
        {
            InitializeComponent();
            //InitializeComponent();
        }
        private void rct_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagReading)
            rct.Opacity = 0;
        }
        private void rct_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagReading)
            //txb.Text = "hihi";
            rct.Opacity = 0.5;
        }
        private void rct_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
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

       

        public static readonly DependencyProperty TextProperty =
    DependencyProperty.Register(
    "myText", typeof(string),
    typeof(MyButton), null
    );
        public string myText
        {
            get { return txb.Text; }
            set { txb.Text = value; }
        }

    }
}
