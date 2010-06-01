using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using UISample.ReadingServiceReference;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Xml;

namespace UISample
{
	public partial class MainPage : UserControl
	{

		bool flagReading = true;
		bool flagListening = true;
		bool flagSpeaking = true;
		bool flagWriting = true;
		bool flagLanguageFocus = true;
        bool flagFindControl = true;

        
		
		
		public MainPage()
		{
			// Required to initialize variables
			InitializeComponent();
            strbShowUnitGrid.Begin();
            
            //load vocabulary
            VocabularyServiceReference.VocabularyServiceClient serviceVoca = new UISample.VocabularyServiceReference.VocabularyServiceClient();
            serviceVoca.GetVocabularyCompleted +=new EventHandler<UISample.VocabularyServiceReference.GetVocabularyCompletedEventArgs>(serviceVoca_GetVocabularyCompleted);
            serviceVoca.GetVocabularyAsync();
            //load unit control
            ucUnitList.AddUnit(12);            

		}

        void serviceVoca_GetVocabularyCompleted(object sender, UISample.VocabularyServiceReference.GetVocabularyCompletedEventArgs e)
        {
            if (e.Error != null)
                return;
            List<VocabularyServiceReference.VOCABULARY> listVoca = e.Result.ToList();
            List<string> listEword = new List<string>();
            List<string> listVword = new List<string>();
            foreach (UISample.VocabularyServiceReference.VOCABULARY item in listVoca)
            {
                listVword.Add(item.Vword);
                listEword.Add(item.Eword);
            }
            findControl.ItemSource(listEword, listVword);
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

            if (ucUnitList.Unit > 0)
            {
                rctrlReadingContent.SelectedUnit = ucUnitList.Unit;

                rctrlReadingContent.Visibility = Visibility.Visible;
                sctrlSpeakingContent.Visibility = Visibility.Collapsed;
                lctrlListeningContent.Visibility = Visibility.Collapsed;
                wctrlWritingContent.Visibility = Visibility.Collapsed;
                lfctrlLangFocusContent.Visibility = Visibility.Collapsed;

                strbShowReadingContent.Begin();
            }
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

            if (ucUnitList.Unit > 0)
            {
                //sctrlSpeakingContent

                rctrlReadingContent.Visibility = Visibility.Collapsed;
                sctrlSpeakingContent.Visibility = Visibility.Visible;
                lctrlListeningContent.Visibility = Visibility.Collapsed;
                wctrlWritingContent.Visibility = Visibility.Collapsed;
                lfctrlLangFocusContent.Visibility = Visibility.Collapsed;

                strbShowReadingContent.Begin();
                sctrlSpeakingContent.Begin(ucUnitList.Unit);
            }
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

            if (ucUnitList.Unit > 0)
            {
                //rctrlReadingContent.SelectedUnit = ucUnitList.Unit;
                lctrlListeningContent.SelectedUnit = ucUnitList.Unit;

                rctrlReadingContent.Visibility = Visibility.Collapsed;
                sctrlSpeakingContent.Visibility = Visibility.Collapsed;
                lctrlListeningContent.Visibility = Visibility.Visible;
                wctrlWritingContent.Visibility = Visibility.Collapsed;
                lfctrlLangFocusContent.Visibility = Visibility.Collapsed;

                strbShowReadingContent.Begin();
            }
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

            if (ucUnitList.Unit > 0)
            {
                rctrlReadingContent.Visibility = Visibility.Collapsed;
                sctrlSpeakingContent.Visibility = Visibility.Collapsed;
                lctrlListeningContent.Visibility = Visibility.Collapsed;
                wctrlWritingContent.Visibility = Visibility.Visible;
                lfctrlLangFocusContent.Visibility = Visibility.Collapsed;
                wctrlWritingContent.LoadContent(ucUnitList.Unit);
                strbShowReadingContent.Begin();
            }
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

            if (ucUnitList.Unit > 0)
            {
                rctrlReadingContent.Visibility = Visibility.Collapsed;
                sctrlSpeakingContent.Visibility = Visibility.Collapsed;
                lctrlListeningContent.Visibility = Visibility.Collapsed;
                wctrlWritingContent.Visibility = Visibility.Collapsed;
                lfctrlLangFocusContent.Visibility = Visibility.Visible;                
                strbShowReadingContent.Begin();
                //grammar
                lfctrlLangFocusContent.SelectUnitSet(ucUnitList.Unit);

                //pronunciation
                lfctrlLangFocusContent.UnitSelected = "Data/" + "Unit_" + ucUnitList.Unit.ToString() + "/Language Focus/";
                lfctrlLangFocusContent.pathXML = "Data/Pronunciation/Unit_" + ucUnitList.Unit.ToString() + ".xml";
                lfctrlLangFocusContent.cvMainPronun.Visibility = Visibility.Collapsed;

                lfctrlLangFocusContent.cvMainPronun.Visibility = Visibility.Collapsed; 
                lfctrlLangFocusContent.gridGrammar.Visibility = Visibility.Collapsed;
            }
		}

		private void btnTriangle_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
            lfctrlLangFocusContent.strb_ShowGrammarReverse.Begin();
            strbShowReadingContentReverse.Begin();
		}

		private void button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            if (flagFindControl == true)
            {
                strbFindAnimation.Begin();
                flagFindControl = false;
            }
            else
            {
                strbFindAnimation_Copy1.Begin();
                flagFindControl = true;
            }
			// TODO: Add event handler implementation here.
		}

		private void bnt_grammar_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.            
            lfctrlLangFocusContent.cvMainPronun.Visibility = Visibility.Collapsed;
            lfctrlLangFocusContent.gridGrammar.Visibility = Visibility.Collapsed;
            lfctrlLangFocusContent.currentPage = 1;
            lfctrlLangFocusContent.strb_ShowGrammar.Begin();
            lfctrlLangFocusContent.tb_Page.Text = lfctrlLangFocusContent.currentPage.ToString() + "/" + lfctrlLangFocusContent.array[lfctrlLangFocusContent.SelectedUnit].ToString();
            lfctrlLangFocusContent.UnitSelected = "Data/" + "Unit_" + ucUnitList.Unit.ToString() + "/Language Focus/";
            lfctrlLangFocusContent.pathXML = "Data/Pronunciation/Unit_" + ucUnitList.Unit.ToString() + ".xml";
            lfctrlLangFocusContent.rtb_Grammar.RichTextURL = String.Format(@"Data/Question/Unit{0}_Q{1}.xml", lfctrlLangFocusContent.SelectedUnit, lfctrlLangFocusContent.currentPage);
            lfctrlLangFocusContent.rtb_Answer.RichTextURL = String.Format(@"Data/Answer/Unit{0}_E{1}.xml", lfctrlLangFocusContent.SelectedUnit, lfctrlLangFocusContent.currentPage);
            //pronunciation            
            
			
		}

		private void ucUnitList_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
            if (ucUnitList.Unit > 0)
            {
             //   rtbReviewContent.RichTextURL = String.Format(@"Data/ReadingData/english/Reading_Unit{0}_EngText.xml", ucUnitList.Unit);
                //RichText
            }
			
		}

		private void ucUnitList_LayoutUpdated(object sender, System.EventArgs e)
		{
			 // TODO: Add event handler implementation here.
            if (ucUnitList.Unit > 0)
            {
              //  rtbReviewContent.RichTextURL = String.Format(@"Data/ReadingData/english/Reading_Unit{0}_EngText.xml", ucUnitList.Unit);
            }
		}

		private void txbChooseUnit_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if (ucUnitList.Unit > 0)
            {
              rtbReviewContent.RichTextURL = String.Format(@"Data/ReadingData/english/Bai{0}.xml", ucUnitList.Unit);
            }
		}

        

	}
}