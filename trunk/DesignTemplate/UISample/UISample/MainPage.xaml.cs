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
	public partial class MainPage : UserControl
	{
		bool flagUnit1 = true;
		bool flagUnit2 = true;
		bool flagUnit3 = true;
		
		bool flagReading = true;
		bool flagListening = true;
		bool flagSpeaking = true;
		bool flagWriting = true;
		bool flagLanguageFocus = true;
		
		
		public MainPage()
		{
			// Required to initialize variables
			InitializeComponent();
		}
		
		//unit 1
		private void rctUnit1_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit1)
				rctUnit1.Opacity = 0;
		}

		private void rctUnit1_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit1)
				rctUnit1.Opacity = 0.5;
		}
		
		private void rctUnit1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			rctUnit1.Opacity = 0.5;
			rctUnit2.Opacity = 0;
			rctUnit3.Opacity = 0;
			flagUnit1 = false;
			flagUnit2 = true;
			flagUnit3 = true;
		}
		
		//unit 2
		private void rctUnit2_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit2)
				rctUnit2.Opacity = 0;
		}

		private void rctUnit2_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit2)
				rctUnit2.Opacity = 0.5;
		}
		
		private void rctUnit2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			rctUnit2.Opacity = 0.5;
			rctUnit1.Opacity = 0;
			rctUnit3.Opacity = 0;
			flagUnit2 = false;
			flagUnit1 = true;
			flagUnit3 = true;
		}
		
		//unit 3
		private void rctUnit3_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit3)
				rctUnit3.Opacity = 0;
		}
		
		private void rctUnit3_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit3)
				rctUnit3.Opacity = 0.5;
		}

		private void rctUnit3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			rctUnit3.Opacity = 0.5;
			rctUnit1.Opacity = 0;
			rctUnit2.Opacity = 0;
			flagUnit3 = false;
			flagUnit1 = true;
			flagUnit2 = true;
		}
		
		//Reading
		private void rctReading_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagReading)
				rctReading.Opacity = 0;
		}

		private void rctReading_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagReading)
				rctReading.Opacity = 0.5;
		}
		
		private void rctReading_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			rctReading.Opacity = 0.5;
			rctSpeaking.Opacity = 0;
			rctListening.Opacity = 0;
			rctLanguageFocus.Opacity = 0;
			rctWriting.Opacity = 0;
			flagReading = false;
			flagListening = true;
			flagWriting = true;
			flagLanguageFocus = true;
			flagSpeaking = true;
		}

		//Speaking
		private void rctSpeaking_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagSpeaking)
				rctSpeaking.Opacity = 0;
		}

		private void rctSpeaking_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagSpeaking)
				rctSpeaking.Opacity = 0.5;
		}

		private void rctSpeaking_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			rctSpeaking.Opacity = 0.5;
			rctReading.Opacity = 0;
			rctListening.Opacity = 0;
			rctLanguageFocus.Opacity = 0;
			rctWriting.Opacity = 0;
			flagSpeaking = false;
			flagReading = true;
			flagListening = true;
			flagWriting = true;
			flagLanguageFocus = true;
		}

		//Listening
		private void rctListening_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagListening)
				rctListening.Opacity = 0;
		}

		private void rctListening_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagListening)
				rctListening.Opacity = 0.5;
		}

		private void rctListening_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			rctListening.Opacity = 0.5;
			rctSpeaking.Opacity = 0;
			rctReading.Opacity = 0;
			rctLanguageFocus.Opacity = 0;
			rctWriting.Opacity = 0;
			flagListening = false;
			flagSpeaking = true;
			flagReading = true;
			flagWriting = true;
			flagLanguageFocus = true;
		}

		//Writing
		private void rctWriting_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagWriting)
				rctWriting.Opacity = 0;
		}

		private void rctWriting_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagWriting)
				rctWriting.Opacity = 0.5;
		}
		
		private void rctWriting_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			rctWriting.Opacity = 0.5;
			rctListening.Opacity = 0;
			rctSpeaking.Opacity = 0;
			rctReading.Opacity = 0;
			rctLanguageFocus.Opacity= 0;
			flagWriting = false;
			flagListening = true;
			flagSpeaking = true;
			flagReading = true;
			flagLanguageFocus = true;
		}

		//LanguageFocus
		private void rctLanguageFocus_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagLanguageFocus)
				rctLanguageFocus.Opacity = 0;
		}

		private void rctLanguageFocus_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagLanguageFocus)
				rctLanguageFocus.Opacity = 0.5;
		}
		
		private void rctLanguageFocus_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			rctLanguageFocus.Opacity = 0.5;
			rctWriting.Opacity = 0;
			rctListening.Opacity = 0;
			rctSpeaking.Opacity = 0;
			rctReading.Opacity = 0;
			flagLanguageFocus = false;
			flagWriting = true;
			flagListening = true;
			flagSpeaking = true;
			flagReading = true;
		}		
	}
}