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
	public partial class ReadingControl : UserControl
	{

        /// <summary>
        /// The <see cref="SelectedUnit" /> dependency property's name.
        /// </summary>
        public const string SelectedUnitPropertyName = "SelectedUnit";

        /// <summary>
        /// Gets or sets the value of the <see cref="SelectedUnit" />
        /// property. This is a dependency property.
        /// </summary>
        public int SelectedUnit
        {
            get
            {
                return (int)GetValue(SelectedUnitProperty);
            }
            set
            {
                if(value > 0)
                    SetValue(SelectedUnitProperty, value);
            }
        }

        /// <summary>
        /// Identifies the <see cref="SelectedUnit" /> dependency property.
        /// </summary>
        public static readonly DependencyProperty SelectedUnitProperty = DependencyProperty.Register(
            SelectedUnitPropertyName,
            typeof(int),
            typeof(ReadingControl),
            new PropertyMetadata(0,OnSelectedUnitChanged));

        private static string DescriptionFileName = "ReadingDescription.xml";

        private int iNumberOfPictures;

        private int iNumberOfAudioFiles;

        private int iNumberOfTasks;

        private List<SelectionPartControl> selectionExList;

        private List<FillInBlankControl> fillInBlankList;

		public ReadingControl()
		{
			// Required to initialize variables
			InitializeComponent();

            selectionExList = new List<SelectionPartControl>();

            fillInBlankList = new List<FillInBlankControl>();

            ResetAll();

            
		}


        public void ResetAll()
        {
            rtxtEngReadingText.Visibility = Visibility.Collapsed;

            rtxtEngReadingText.Visibility = Visibility.Collapsed;

            rpcReadingPractice.Visibility = Visibility.Collapsed;

            audioPlayer.Visibility = Visibility.Visible;
			
			buttonAnswer.Visibility = Visibility.Collapsed;

            selectionExList.Clear();

            fillInBlankList.Clear();

            nextButton.Visibility = Visibility.Collapsed;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private static void OnSelectedUnitChanged(DependencyObject src, DependencyPropertyChangedEventArgs args)
        {
            ReadingControl readingControl = src as ReadingControl;

            if (src == null)
                return;

            readingControl.LoadReadingContent();
        }

        private void LoadReadingContent()
        {
            if(SelectedUnit == 0)
                return;

            ResetAll();

            txbTitle.Text = "Unit " + SelectedUnit.ToString() + " Reading";

            LoadReadingDescriptionFile();

            LoadAudioFiles();

            LoadPictures();

            LoadPratice();
            LoadText();
        }

        private void LoadReadingDescriptionFile()
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreComments = true;
                settings.IgnoreProcessingInstructions = true;
                settings.IgnoreWhitespace = true;
                XmlReader reader = XmlReader.Create(string.Format("Data/Unit_{0}/Reading/" + DescriptionFileName,SelectedUnit), settings);

                reader.MoveToContent();

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Unit")
                    {

                    }

                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Audio")
                    {
                        iNumberOfAudioFiles = reader.ReadElementContentAsInt();
                    }

                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Pictures")
                    {
                        iNumberOfPictures = reader.ReadElementContentAsInt();
                    }

                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Practice")
                    {
                        iNumberOfTasks = reader.ReadElementContentAsInt();
                    }
                }

                //isOK = true;
                reader.Close();
            }
            catch (Exception e)
            {
                //isOK = false;
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK);
            }
        }

        private void LoadAudioFiles()
        {
            try
            {
                audioPlayer.UriSource = new Uri(string.Format("Data/Unit_{0}/Reading/Audio/Reading_Unit{0}.mp3", SelectedUnit),UriKind.RelativeOrAbsolute);
            }
            catch (Exception e)
            {
                audioPlayer.UriSource = null;
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK);
            }
        }

        private void LoadPictures()
        {
        }

        private void LoadPratice()
        {
            for (int i = 0; i < iNumberOfTasks; ++i)
            {

                try
                {

                    string path = string.Format("Data/Unit_{0}/Reading/Practice/Reading_Practice_Unit{0}_Task{1}.xml", SelectedUnit, i + 1);
                    rpcReadingPractice.AddPractice(path);
                    
                }
                catch ( Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButton.OK);
                    //throw;
                }
            }
        }

        private void LoadText()
        {
            try
            {
                rtxtEngReadingText.RichTextURL = string.Format("Data/ReadingData/english/Bai{0}.xml", SelectedUnit);
                rtxtVietReadingText.RichTextURL = string.Format("Data/ReadingData/vietnam/Reading_Unit{0}_VietText.xml", SelectedUnit);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK);
            }
        }

        private void bntPractice_Click(object sender, RoutedEventArgs e)
        {
            ResetAll();
            rpcReadingPractice.Visibility = Visibility.Visible;
            buttonAnswer.Visibility = Visibility.Visible;


            rtxtEngReadingText.Visibility = Visibility.Collapsed;
            rtxtVietReadingText.Visibility = Visibility.Collapsed;

            nextButton.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Visible;
        }

        private void bntEnglish_Click(object sender, RoutedEventArgs e)
        {
            ResetAll();
            rtxtEngReadingText.Visibility = Visibility.Visible;
            rtxtVietReadingText.Visibility = Visibility.Collapsed;
            rpcReadingPractice.Visibility = Visibility.Collapsed;

            nextButton.Visibility = Visibility.Collapsed;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void bntVietnam_Click(object sender, RoutedEventArgs e)
        {
            ResetAll();
            rtxtVietReadingText.Visibility = Visibility.Visible;
            rtxtEngReadingText.Visibility = Visibility.Collapsed;
            rpcReadingPractice.Visibility = Visibility.Collapsed;

            nextButton.Visibility = Visibility.Collapsed;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void buttonAnswer_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            rpcReadingPractice.FixWrongSentence();
        }

        private void nextButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            rpcReadingPractice.NextPage();
        }

        private void BackButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            rpcReadingPractice.PreviousPage();
        }
	}
}