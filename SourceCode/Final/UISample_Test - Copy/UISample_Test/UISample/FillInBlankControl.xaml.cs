using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Xml;
using Liquid;
using System.Text;

//Cai khi nay lam ton qua nhieu thoi gian.
//version1:tạm dừng ở đây do bị bug trong RichTextBox

namespace UISample
{
    
    public partial class FillInBlankControl : UserControl
    {

        List<TextBox> txtTextList = new List<TextBox>();

        List<ComboBox> cbxList = new List<ComboBox>();

        List<string> suggestionList = new List<string>();

        List<string> correctAnswerList = new List<string>();


        public FillInBlankControl()
        {
            InitializeComponent();

            rtxtContent.ID = "root";
            
            //rtxtContent.Styles.Add("Normal", new RichTextBoxStyle("Normal", "Arial", 14, FontWeights.Normal));


            rtxtContent.ApplyTemplate();
            rtxtContent.UpdateLayout();
        }

        public void LoadContentFromXML(string fileName)
        {
            rtxtContent.SelectMode = SelectMode.Edit;

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;
            settings.IgnoreWhitespace = true;
            XmlReader reader = XmlReader.Create(fileName, settings);

            reader.MoveToContent();

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Words")
                    ReadOptions(reader, suggestionList);

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "CorrectAnswers")
                    ReadCorrectAnswers(reader, correctAnswerList);

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Content")
                {
                    rtxtContent.RichTextURL = reader.ReadElementContentAsString();
                    rtxtContent.UpdateLayout();
                }
            }

            reader.Close();

            rtxtContent.SelectMode = SelectMode.Select;

            //Tìm TextBox
            int count = 0;
            for (int i = 0; i < rtxtContent.Children.Count; ++i)
            {
                ComboBox cbxCombo = rtxtContent.Children[i] as ComboBox;
                if (cbxCombo != null)
                {
                    count++;
                    cbxList.Add(cbxCombo);
                }
            }

            System.Diagnostics.Debug.WriteLine("RichTextBox.Children have {0} border", count);
        }

        public void LoadContentFromStream(Stream stream)
        {
            rtxtContent.SelectMode = SelectMode.Edit;

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;
            settings.IgnoreWhitespace = true;
            XmlReader reader = XmlReader.Create(stream,settings);

            reader.MoveToContent();

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Words")
                    ReadOptions(reader, suggestionList);

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "CorrectAnswers")
                    ReadCorrectAnswers(reader, correctAnswerList);

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "LiquidRichText")
                {
                    rtxtContent.RichTextURL = reader.ReadElementContentAsString();
                }
            }

            reader.Close();

            rtxtContent.SelectMode = SelectMode.Select;

            //Tìm TextBox
            int count = 0;
            for (int i = 0; i < rtxtContent.Children.Count; ++i)
            {
                ComboBox cbxCombo = rtxtContent.Children[i] as ComboBox;
                if (cbxCombo != null)
                {
                    count++;
                    cbxList.Add(cbxCombo);
                }
            }

            System.Diagnostics.Debug.WriteLine("RichTextBox.Children have {0} border", count);
        }

        private void ReadOptions(XmlReader reader, List<string> optionList)
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Option")
                {
                    optionList.Add(reader.ReadElementContentAsString());
                }

                if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Words")
                    break;
            }
        }

        private void ReadCorrectAnswers(XmlReader reader, List<string> list)
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Ans")
                {
                    list.Add(reader.ReadElementContentAsString());
                }

                if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "CorrectAnswers")
                    break;
            }
        }

        public string XmlReaderToString(XmlReader reader)
        {

            StringBuilder xmlStringBuilder = new StringBuilder();
            xmlStringBuilder.Append(reader.ReadOuterXml());
            return xmlStringBuilder.ToString();
        }

        public void FixWrongSentences()
        {
            for (int i = 0; i < cbxList.Count; ++i)
            {
                ComboBox cbxBlank = cbxList[i];

                ComboBoxItem item = cbxBlank.SelectionBoxItem as ComboBoxItem;


                string temp="";

                //if (temp == null)
                //    continue;

                if (temp.CompareTo(correctAnswerList[i]) != 0)
                {
                    int index = cbxBlank.Items.IndexOf(correctAnswerList[i]);
                    cbxBlank.SelectedIndex = index;
                }

            }
        }

    }

}
