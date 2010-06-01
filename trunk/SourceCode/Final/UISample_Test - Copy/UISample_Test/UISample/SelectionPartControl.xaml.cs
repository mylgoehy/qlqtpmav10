//TestControl.xaml.cs
//*************************************************
//Tac gia:anewhope2109
//Noi dung:
//  Classes:TestControl
//  Functions:
//      private void InitGrid()
//      private void InitHeader()
//      public void LoadContentFromXml(string fileName)
//      public void AddOneItem(QuestionControl item)
//      public void AddOneItem(string question, List<string> selections, int correct)
//      public void TittleAlignment(TextAlignment alignment)
//      private void LayoutRoot_MouseWheel(object sender, MouseWheelEventArgs e)
//      public int TotalCorrectSelections()
//      public void LockControl();
//      public void UnLockControl();
//        
//  Class Members:
//      Grid gridChildLayout
//      RowDefinitionCollection rowDefCollection
//      TextBlock txbtittle
//      String strTittle
//      List<QuestionControl> qclItems
//      int iNumItem
//      bool isLocked
//
//Version:    1.0
//  Ngay bat dau:25-04-2010
//  Ngay ket thuc:03-05-2010
//
//Ghi chu:
//  Epression blend se khong hien thi duoc cai control nay
//      , do control nay duoc xay hoan toan bang code c#.
//
//Qua trinh sua doi:

//*************************************************

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
using System.Xml;
using System.IO;

namespace UISample
{
    
    public partial class SelectionPartControl : UserControl
    {
        #region Attributes
        //Grid chua cac QuestionControl.
        public Grid gridChildLayout;

        private RowDefinitionCollection rowDefCollection;

        public TextBlock txbTittle;

        private String strTittle;

        List<SentenceCorrectionControl> qclItems;

        private int iNumItem;

        private bool isLocked;

        private Color clWrong;
        #endregion Attributes


        #region Properties
        public String Tittle
        {
            get { return strTittle; }
            set
            {
                strTittle = value;
                txbTittle.Text = value;
            }
        }
        #endregion Properties


        #region Constructors
        public SelectionPartControl()
        {
            InitializeComponent();

            qclItems = new List<SentenceCorrectionControl>();

            iNumItem = 0;

            clWrong = Colors.Red;

            InitGrid();

            InitHeader();
        }
        #endregion Constructors


        #region Functions
        private void InitGrid()
        {
            
            gridChildLayout = new Grid();
            LayoutRoot.Content = gridChildLayout;

            gridChildLayout.VerticalAlignment = VerticalAlignment.Top;
            gridChildLayout.HorizontalAlignment = HorizontalAlignment.Left;

            gridChildLayout.ShowGridLines = true;

            rowDefCollection = gridChildLayout.RowDefinitions;

            for (int i = 0; i < iNumItem + 1; ++i)
            {
                RowDefinition rowDef = new RowDefinition();
                rowDefCollection.Add(rowDef);
            }
        }

        private void InitHeader()
        {
            txbTittle = new TextBlock();
            txbTittle.TextWrapping = TextWrapping.Wrap;
            Grid.SetRow(txbTittle, 0);
            gridChildLayout.Children.Add(txbTittle);
        }

        //Tinh tai noi dung cua phan bai trac nghiem tu file xml
        public void LoadContentFromXml(string fileName)
        {
            if (fileName == null || fileName == string.Empty)
                return;

            ResetAll();

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;
            XmlReader reader = XmlReader.Create(fileName, settings);

            reader.MoveToContent();

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Type")
                {
                    int type = reader.ReadElementContentAsInt();
                    if (type != 0)
                        return;
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Heading")
                {
                    Tittle = reader.ReadElementContentAsString();
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Question")
                {
                    AddQuestionContent(reader);
                }
            }

            reader.Close();
        }

        //Tai noi dung cua phan bai trac nghiem tu stream.
        public void LoadContentFromStream(Stream stream)
        {
            if (stream == null)
                return;

            ResetAll();

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;
            XmlReader reader = XmlReader.Create(stream, settings);

            reader.MoveToContent();
            
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Type")
                {
                    int type = reader.ReadElementContentAsInt();
                    if (type != 0)
                        return;
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Heading")
                {
                    Tittle = reader.ReadElementContentAsString();
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Question")
                {
                    AddQuestionContent(reader);
                }
            }

            reader.Close();
        }

        private void AddQuestionContent(XmlReader reader)
        {
            string strAsk = null;
            List<string> selections = new List<string>();
            List<int> correctAnswers = new List<int>();

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Ask")
                {
                    strAsk = reader.ReadElementContentAsString();
                }

                while (reader.NodeType == XmlNodeType.Element && reader.Name == "Option")
                {
                    selections.Add(reader.ReadElementContentAsString());
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "CorrectAnswer")
                {
                    correctAnswers.Add(reader.ReadElementContentAsInt());
                }
                    
                if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Question")
                {
                    break;
                }
            }

            if (strAsk != null && selections.Count > 1)
                AddOneItem(strAsk, selections, correctAnswers);
            
        } 

        //Tai cau tra loi dung
        public void LoadCorrectAnswers(List<string> correctAnswerList)
        {
            if (qclItems.Count != correctAnswerList.Count)
            {
                MessageBox.Show("Lỗi CSDL: Số câu trả lời trong database và số câu hỏi khác nhau!!!", "Thong Bao", MessageBoxButton.OK);
                return;
            }

            for (int i = 0; i < correctAnswerList.Count; ++i)
            {
                qclItems[i].CorrectAnswer = int.Parse(correctAnswerList[i]);
            }
        }

        //Them QuestionControl vao qclItems
        public void AddOneItem(SentenceCorrectionControl item)
        {
            rowDefCollection.Insert(iNumItem + 1, new RowDefinition());

            Grid.SetRow(item, iNumItem + 1);

            item.Margin = new Thickness(10.00, 0.00, 0.00, 0.00);

            item.VerticalAlignment = VerticalAlignment.Center;

            ++iNumItem;

            qclItems.Add(item);

            gridChildLayout.Children.Add(item);

        }

        public void AddOneItem(string question, List<string> selections, List<int> answers)
        {
            SentenceCorrectionControl item = new SentenceCorrectionControl();

            if (item == null)
                return;

            item.QuestionContent = question;

            foreach (int i in answers)
            {
                item.CorrectAnswer = i;
            }

            foreach (string str in selections)
            {
                item.AddOneSelection(str);
            }

            AddOneItem(item);
        }

        //Canh trai canh phai canh giua cho tieu de
        public void TittleAlignment(string temp)
        {
            if (temp == "Left")
            {
                txbTittle.TextAlignment = TextAlignment.Left;
            }

            if (temp == "Right")
            {
                txbTittle.TextAlignment = TextAlignment.Right;
            }

            if (temp == "Center")
            {
                txbTittle.TextAlignment = TextAlignment.Center;
            }
        }

        public void TittleAlignment(TextAlignment alignment)
        {
            txbTittle.TextAlignment = alignment;
        }

        //Xu ly su kien cuon chuot.
        private void LayoutRoot_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollViewer = sender as ScrollViewer;

            if (scrollViewer == null)
                return;
            

            if (e.Delta > 0)
                scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - 20.00);

            if (e.Delta < 0)
                scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset + 20.00);

            
        }

        //Xoa cau hoi trong tung cau trac nghiem :D.Cai nay ko can dung`.
        public static void Clear(DependencyObject element)
        {
            TextBlock textBlock = element as TextBlock;
            if (textBlock != null) textBlock.Text = String.Empty;

            RadioButton radioBtn = element as RadioButton;
            if (radioBtn != null) return;

            int count = VisualTreeHelper.GetChildrenCount(element);
            for (int i = 0; i < count; ++i)
            {
                DependencyObject child = VisualTreeHelper.GetChild(element, i);
                Clear(child);
            }

            
        }

        //Tra ve so cau danh dung' cua user
        public int TotalCorrectSelections()
        {
            if (qclItems == null || qclItems.Count == 0)
                return 0;

            int iCount = 0;
            for (int i = 0; i < iNumItem; ++i)
            {
                SentenceCorrectionControl item = qclItems[i];
                if (item == null)
                    continue;

                if (item.IsCorrectSelection())
                    ++iCount;
            }

            return iCount;
        }

        public int TotalWrongSelections()
        {
            return qclItems.Count - TotalCorrectSelections();
        }

        //Sua cau sai
        public void FixWrongSentences()
        {
            SentenceCorrectionControl item;
            for (int i = 0; i < qclItems.Count; ++i)
            {
                item = qclItems[i];

                //Neu tra loi sai
                if (item.IsCorrectSelection() == false)
                {                    
                    clWrong = Colors.Red;
                    item.Fix();
                    item.Background = new SolidColorBrush(clWrong);
                    item.Foreground = new SolidColorBrush(clWrong); 
                    item.UpdateLayout();
                }
            }
            LayoutRoot.UpdateLayout();
        }
        
        //Khoa control ko cho user tuong tac
        public void LockControl()
        {
            if (isLocked == true)
                return;

            isLocked = true;
       
            foreach (SentenceCorrectionControl control in qclItems)
            {
                control.LockControl();
            }
        }

        //Mo khoa control
        public void UnLockControl()
        {
            if (isLocked == false)
                return;

            isLocked = false;

            foreach (SentenceCorrectionControl control in qclItems)
            {
                control.UnLockControl();
            }
        }

        public void ResetAll()
        {
            gridChildLayout.RowDefinitions.Clear();

            gridChildLayout.Children.Clear();

            txbTittle.Text = string.Empty;

            strTittle = string.Empty;

            iNumItem = 0;

            clWrong = Colors.Red;

            InitGrid();
            InitHeader();
        }
        #endregion Functions

        
    }
}
