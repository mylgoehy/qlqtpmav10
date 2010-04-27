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
		private void Rect_Unit1_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit1)
				Rect_Unit1.Opacity = 0;
		}

		private void Rect_Unit1_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit1)
				Rect_Unit1.Opacity = 0.5;
		}
		
		private void Rect_Unit1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Rect_Unit1.Opacity = 0.5;
			Rect_Unit2.Opacity = 0;
			Rect_Unit3.Opacity = 0;
			flagUnit1 = false;
			flagUnit2 = true;
			flagUnit3 = true;
		}
		
		//unit 2
		private void Rect_Unit2_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit2)
				Rect_Unit2.Opacity = 0;
		}

		private void Rect_Unit2_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit2)
				Rect_Unit2.Opacity = 0.5;
		}
		
		private void Rect_Unit2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Rect_Unit2.Opacity = 0.5;
			Rect_Unit1.Opacity = 0;
			Rect_Unit3.Opacity = 0;
			flagUnit2 = false;
			flagUnit1 = true;
			flagUnit3 = true;
		}
		
		//unit 3
		private void Rect_Unit3_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit3)
				Rect_Unit3.Opacity = 0;
		}

		private void Rect_Unit3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Rect_Unit3.Opacity = 0.5;
			Rect_Unit1.Opacity = 0;
			Rect_Unit2.Opacity = 0;
			flagUnit3 = false;
			flagUnit1 = true;
			flagUnit2 = true;
		}

		private void Rect_Unit3_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagUnit3)
				Rect_Unit3.Opacity = 0.5;
		}

		//Reading
		private void Rect_Reading_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagReading)
				Rect_Reading.Opacity = 0;
		}

		private void Rect_Reading_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Rect_Reading.Opacity = 0.5;
			Rect_Speaking.Opacity = 0;
			Rect_Listening.Opacity = 0;
			Rect_LanguageFocus.Opacity = 0;
			Rect_Writing.Opacity = 0;
			flagReading = false;
			flagListening = true;
			flagWriting = true;
			flagLanguageFocus = true;
			flagSpeaking = true;
		}

		private void Rect_Reading_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagReading)
				Rect_Reading.Opacity = 0.5;
		}

		//Speaking
		private void Rect_Speaking_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagSpeaking)
				Rect_Speaking.Opacity = 0;
		}

		private void Rect_Speaking_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Rect_Speaking.Opacity = 0.5;
			Rect_Reading.Opacity = 0;
			Rect_Listening.Opacity = 0;
			Rect_LanguageFocus.Opacity = 0;
			Rect_Writing.Opacity = 0;
			flagSpeaking = false;
			flagReading = true;
			flagListening = true;
			flagWriting = true;
			flagLanguageFocus = true;
		}

		private void Rect_Speaking_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagSpeaking)
				Rect_Speaking.Opacity = 0.5;
		}

		//Listening
		private void Rect_Listening_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagListening)
				Rect_Listening.Opacity = 0;
		}

		private void Rect_Listening_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Rect_Listening.Opacity = 0.5;
			Rect_Speaking.Opacity = 0;
			Rect_Reading.Opacity = 0;
			Rect_LanguageFocus.Opacity = 0;
			Rect_Writing.Opacity = 0;
			flagListening = false;
			flagSpeaking = true;
			flagReading = true;
			flagWriting = true;
			flagLanguageFocus = true;
		}

		private void Rect_Listening_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagListening)
				Rect_Listening.Opacity = 0.5;
		}

		//Writing
		private void Rect_Writing_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagWriting)
				Rect_Writing.Opacity = 0;
		}

		private void Rect_Writing_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Rect_Writing.Opacity = 0.5;
			Rect_Listening.Opacity = 0;
			Rect_Speaking.Opacity = 0;
			Rect_Reading.Opacity = 0;
			Rect_LanguageFocus.Opacity= 0;
			flagWriting = false;
			flagListening = true;
			flagSpeaking = true;
			flagReading = true;
			flagLanguageFocus = true;
		}

		private void Rect_Writing_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagWriting)
				Rect_Writing.Opacity = 0.5;
		}

		//LanguageFocus
		private void Rect_LanguageFocus_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagLanguageFocus)
				Rect_LanguageFocus.Opacity = 0;
		}

		private void Rect_LanguageFocus_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Rect_LanguageFocus.Opacity = 0.5;
			Rect_Writing.Opacity = 0;
			Rect_Listening.Opacity = 0;
			Rect_Speaking.Opacity = 0;
			Rect_Reading.Opacity = 0;
			flagLanguageFocus = false;
			flagWriting = true;
			flagListening = true;
			flagSpeaking = true;
			flagReading = true;
		}

		private void Rect_LanguageFocus_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(flagLanguageFocus)
				Rect_LanguageFocus.Opacity = 0.5;
		}
	}
}