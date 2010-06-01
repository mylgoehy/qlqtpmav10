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
using System.Windows.Media.Imaging;


namespace UISample
{
	public partial class SpeakingControl : UserControl
	{
		public int currentUnit;
        public int currentTask;
        public List<string> answers;
        public List<TextBox> textBoxs;

        public SpeakingControl()
        {
            // Required to initialize variables
            InitializeComponent();

            answers = new List<string>();
            textBoxs = new List<TextBox>();
        }

        public void Begin(int unit)
        {
            currentUnit = unit;
            currentTask = 0;
            answers.Clear();
            textBoxs.Clear();
            Task0_Suggestion.Items.Clear();
            Task1_Question.Items.Clear();


            UpdateButton();
            ShowTask();

            txbTitle.Text = string.Format("Unit {0} Speaking", currentUnit);

            // đọc xml
            LoadTask0();
            LoadTask1();
        }
        public void LoadTask0()
        {
            XmlReader xmlReader = XmlReader.Create(string.Format(@"Data/Speaking/Speaking-{0}-0.xml", currentUnit));
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlReader.Name == "title")
                        Task0_Title.Text = xmlReader.ReadInnerXml();

                    if (xmlReader.Name == "text")
                        Task0_Text.Text = xmlReader.ReadInnerXml();

                    if (xmlReader.Name == "suggestion")
                        Task0_Suggestion.Items.Add(xmlReader.ReadInnerXml());
                }
            }
            xmlReader.Close();
        }

        public void LoadTask1()
        {
            XmlReader xmlReader = XmlReader.Create(string.Format(@"Data/Speaking/Speaking-{0}-1.xml", currentUnit));
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlReader.Name == "title")
                        Task1_Title.Text = xmlReader.ReadInnerXml();

                    if (xmlReader.Name == "text")
                    {
                        string str = xmlReader.ReadInnerXml();

                        string[] lines = str.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        foreach (string line in lines)
                        {
                            StackPanel stackPanel = new StackPanel();
                            stackPanel.Orientation = Orientation.Horizontal;

                            int index = line.IndexOf("xxx");
                            if (index < 0)
                                continue;

                            TextBlock textBlock1 = new TextBlock();
                            textBlock1.Text = line.Substring(0, index);
                            stackPanel.Children.Add(textBlock1);

                            TextBox textBox = new TextBox();
                            textBox.Height = 30;
                            textBox.Width = 200;
                            textBox.Text = string.Empty;
                            stackPanel.Children.Add(textBox);
                            textBoxs.Add(textBox);

                            TextBlock textBlock2 = new TextBlock();
                            if (index + 3 < line.Length)
                                textBlock2.Text = line.Substring(index + 3);
                            stackPanel.Children.Add(textBlock2);

                            Task1_Question.Items.Add(stackPanel);
                        }
                    }

                    if (xmlReader.Name == "answer")
                        answers.Add(xmlReader.ReadInnerXml());
                }
            }
            xmlReader.Close();
        }

        public void ShowTask()
        {
            if (currentTask == 0)
            {
                Canvas_Task0.Visibility = Visibility.Visible;
                Canvas_Task1.Visibility = Visibility.Collapsed;
            }
            else
            {
                Canvas_Task0.Visibility = Visibility.Collapsed;
                Canvas_Task1.Visibility = Visibility.Visible;
            }
        }

        public void UpdateButton()
        {
            if (currentTask == 0)
                Back.IsEnabled = false;
            else
                Back.IsEnabled = true;

            if (currentTask == 1)
                Next.IsEnabled = false;
            else
                Next.IsEnabled = true;
        }

        private void Next_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.
            currentTask++;
            UpdateButton();
            ShowTask();
        }

        private void Back_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.
            currentTask--;
            UpdateButton();
            ShowTask();
        }

        private void ShowHide_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.
            if (MainCanvas.Visibility == Visibility.Collapsed)
                MainCanvas.Visibility = Visibility.Visible;
            else
                MainCanvas.Visibility = Visibility.Collapsed;
        }

        private void Result_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.
            int nRight = 0;

            for (int i = 0; i < textBoxs.Count; i++)
            {
                if (textBoxs[i].Text.Trim() == answers[i].Trim())
                {
                    nRight++;
                    textBoxs[i].Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 255));
                }
                else
                {
                    textBoxs[i].Text = answers[i];
                    textBoxs[i].Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                }
            }

            MessageBox.Show("Số câu đúng: " + nRight);
        }
    }          
        
	
}