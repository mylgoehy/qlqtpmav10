using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Net;

namespace UISample
{
	public partial class WritingControl : UserControl
	{
		public WritingControl()
		{
			// Required to initialize variables
			InitializeComponent();
            rtbContent.ApplyTemplate();
                        
		}

        public void LoadContent(int Id_Unit)
        {            
            rtbContent.RichTextURL = String.Format(@"Data/Writting/unit{0}.xml",Id_Unit);            
        }
        public void Exit()
        {
            strbWriteReverse.Begin();
        }
        private void btWrite_Click(object sender, System.Windows.RoutedEventArgs e)
        {
			strbWrite.Begin();
        	// TODO: Add event handler implementation here.
        }

	}
}