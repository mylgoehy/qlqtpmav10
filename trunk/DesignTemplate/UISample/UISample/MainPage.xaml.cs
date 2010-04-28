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
		private void Unit1_rect_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit1)
				Unit1_rect.Opacity = 0;
		}

		private void Unit1_rect_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit1)
				Unit1_rect.Opacity = 0.5;
		}
		
		private void Unit1_rect_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Unit1_rect.Opacity = 0.5;
			Unit2_rect.Opacity = 0;
			Unit3_rect.Opacity = 0;
			flagUnit1 = false;
			flagUnit2 = true;
			flagUnit3 = true;
		}
		
		//unit 2
		private void Unit2_rect_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit2)
				Unit2_rect.Opacity = 0;
		}

		private void Unit2_rect_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit2)
				Unit2_rect.Opacity = 0.5;
		}
		
		private void Unit2_rect_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Unit2_rect.Opacity = 0.5;
			Unit1_rect.Opacity = 0;
			Unit3_rect.Opacity = 0;
			flagUnit2 = false;
			flagUnit1 = true;
			flagUnit3 = true;
		}
		
		//unit 3
		private void Unit3_rect_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit3)
				Unit3_rect.Opacity = 0;
		}
		
		private void Unit3_rect_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit3)
				Unit3_rect.Opacity = 0.5;
		}

		private void Unit3_rect_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Unit3_rect.Opacity = 0.5;
			Unit1_rect.Opacity = 0;
			Unit2_rect.Opacity = 0;
			flagUnit3 = false;
			flagUnit1 = true;
			flagUnit2 = true;
		}
		
		//Reading
		private void Reading_rect_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagReading)
				Reading_rect.Opacity = 0;
		}

		private void Reading_rect_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagReading)
				Reading_rect.Opacity = 0.5;
		}
		
		private void Reading_rect_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Reading_rect.Opacity = 0.5;
			Speaking_rect.Opacity = 0;
			Listening_rect.Opacity = 0;
			LanguageFocus_rect.Opacity = 0;
			Writing_rect.Opacity = 0;
			flagReading = false;
			flagListening = true;
			flagWriting = true;
			flagLanguageFocus = true;
			flagSpeaking = true;
		}

		//Speaking
		private void Speaking_rect_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagSpeaking)
				Speaking_rect.Opacity = 0;
		}

		private void Speaking_rect_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagSpeaking)
				Speaking_rect.Opacity = 0.5;
		}

		private void Speaking_rect_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Speaking_rect.Opacity = 0.5;
			Reading_rect.Opacity = 0;
			Listening_rect.Opacity = 0;
			LanguageFocus_rect.Opacity = 0;
			Writing_rect.Opacity = 0;
			flagSpeaking = false;
			flagReading = true;
			flagListening = true;
			flagWriting = true;
			flagLanguageFocus = true;
		}

		//Listening
		private void Listening_rect_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagListening)
				Listening_rect.Opacity = 0;
		}

		private void Listening_rect_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagListening)
				Listening_rect.Opacity = 0.5;
		}

		private void Listening_rect_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Listening_rect.Opacity = 0.5;
			Speaking_rect.Opacity = 0;
			Reading_rect.Opacity = 0;
			LanguageFocus_rect.Opacity = 0;
			Writing_rect.Opacity = 0;
			flagListening = false;
			flagSpeaking = true;
			flagReading = true;
			flagWriting = true;
			flagLanguageFocus = true;
		}

		//Writing
		private void Writing_rect_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagWriting)
				Writing_rect.Opacity = 0;
		}

		private void Writing_rect_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagWriting)
				Writing_rect.Opacity = 0.5;
		}
		
		private void Writing_rect_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Writing_rect.Opacity = 0.5;
			Listening_rect.Opacity = 0;
			Speaking_rect.Opacity = 0;
			Reading_rect.Opacity = 0;
			LanguageFocus_rect.Opacity= 0;
			flagWriting = false;
			flagListening = true;
			flagSpeaking = true;
			flagReading = true;
			flagLanguageFocus = true;
		}

		//LanguageFocus
		private void LanguageFocus_rect_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagLanguageFocus)
				LanguageFocus_rect.Opacity = 0;
		}

		private void LanguageFocus_rect_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagLanguageFocus)
				LanguageFocus_rect.Opacity = 0.5;
		}
		
		private void LanguageFocus_rect_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			LanguageFocus_rect.Opacity = 0.5;
			Writing_rect.Opacity = 0;
			Listening_rect.Opacity = 0;
			Speaking_rect.Opacity = 0;
			Reading_rect.Opacity = 0;
			flagLanguageFocus = false;
			flagWriting = true;
			flagListening = true;
			flagSpeaking = true;
			flagReading = true;
		}		
	}
}