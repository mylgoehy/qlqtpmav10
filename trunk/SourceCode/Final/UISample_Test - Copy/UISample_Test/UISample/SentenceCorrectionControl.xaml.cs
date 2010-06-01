//QuestionControl.xaml.cs
//*************************************************
//Tac gia:anewhope2109
//Noi dung:
//  Classes:QuestionControl
//  Functions:
//      private void InitTextBlock()
//      private void InitGrid()
//      public void AddOneSelection(string content)
//      private void RadioButton_Checked(object sender, RoutedEventArgs e)
//        
//  Class Members:
//      private RowDefinitionCollection rowDefCollection
//      private TextBlock questionTextBlock
//      private string strQuestionContent
//      private List<RadioButton> rdlOptions
//      private int iNumOption
//      private int iCorrectAnswer
//      private int iUserAnswer;
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
//  Them cac bien sau:
//  Them cac phuong thuc sau
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

namespace UISample
{
    public partial class SentenceCorrectionControl : UserControl
    {
        #region Attributes
        private RowDefinitionCollection rowDefCollection;

        //TextBlock nay chi hien thi 1 doan text co cung font,cung kich co chu,cung mau chu.
        private TextBlock questionTextBlock;

        //Liquid.RichTextBlock nay cho phep hien thi van ban gom nhieu doan co mau chu , font , kich co khac nhau
        //private Liquid.RichTextBlock rtbQuestionRTBlck;

        //Noi dung cua cau hoi
        private string strQuestionContent;
        
        private List<RadioButton> rdlOptions;

        private int iNumOption;

        //cau tra loi dung la cau thu ? trong mang cac lua chon
        private int iCorrectAnswer;
        
        //iUserAnswer = 0 la chua duoc chon.
        //iUserAnswer = 1->iNumOption la chi soda chon theo thu tu radiobutton
        private int iUserAnswer;

        //Danh dau xem user da chon cau tra loi nao hay chua
        private bool isChecked;

        private bool isLocked;
        #endregion Attributes


        #region Properties
        public string QuestionContent
        {
            get { return strQuestionContent; }
            set
            {
                strQuestionContent = value;
                questionTextBlock.Text = value;
            }
        }

        public int CorrectAnswer
        {
            get { return iCorrectAnswer; }
            set { iCorrectAnswer = value; }
        }

        public int UserAnswer
        {
            get { return iUserAnswer; }
        }
        #endregion Properties


        #region Constructors
        public SentenceCorrectionControl()
        {
            InitializeComponent();

            InitGrid();

            InitTextBlock();

            rdlOptions = new List<RadioButton>();

            isChecked = false;

            isLocked = false;

            //LayoutRoot.ShowGridLines = true;

        }
        #endregion Constructors


        #region Functions
        private void InitTextBlock()
        {
            questionTextBlock = new TextBlock();
            questionTextBlock.Text = "Question is:...";
            questionTextBlock.VerticalAlignment = VerticalAlignment.Center;

            Grid.SetRow(questionTextBlock, 1);

            LayoutRoot.ShowGridLines = false;

            LayoutRoot.Children.Add(questionTextBlock);
        }


        //Grid bat dau voi 3 row.
        //  row dau va row cuoi co chieu cao mac dinh la 30
        //  row thu 2 co chieu cao la auto, row thu 2 nay danh cho 'cau hoi'(textblock)
        private void InitGrid()
        {
            rowDefCollection = LayoutRoot.RowDefinitions;

            RowDefinition rowDef;
            rowDef = new RowDefinition();
            rowDef.Height = new GridLength(10.00);
            rowDefCollection.Add(rowDef);

            for (int i = 0; i < iNumOption + 1; ++i)
            {
                rowDef = new RowDefinition();
                GridLength gridLength = new GridLength();
                rowDef.Height = gridLength;
                rowDef.MinHeight = 30.00;
                rowDefCollection.Add(rowDef);
            }

            rowDef = new RowDefinition();
            rowDef.Height = new GridLength(10.00);
            rowDefCollection.Add(rowDef); 
            
        }


        //Them radio button voi noi dung content(la 1 string) vao control.
        public void AddOneSelection(string content)
        {
            RadioButton radioBtn = new RadioButton();

            //gan noi dung cho radioBtn
            radioBtn.Content = string.Copy(content);
            //canh le cho radioBtn
            radioBtn.Margin = new Thickness(10.00, 0.00, 10.00, 0.00);
            //canh cho radioBtn luon o chinh giua row (thoe chieu cao)
            radioBtn.VerticalAlignment = VerticalAlignment.Center;

            //them 1 row danh cho radio button vao Grid
            rowDefCollection.Insert(iNumOption + 2, new RowDefinition());

            //cho Grid biet radioBtn thuoc row nao
            Grid.SetRow(radioBtn, iNumOption + 2);

            //tang so radio button len 1
            ++iNumOption;

            radioBtn.Checked += new RoutedEventHandler(RadioButton_Checked);

            //them radioBtn vao rdlOptions
            rdlOptions.Add(radioBtn);

            //them radioBtn vao LayoutRoot
            LayoutRoot.Children.Add(radioBtn);

            LayoutRoot.UpdateLayout();

            
        }


        //Neu cau tra loi cua user == voi cau tra loi dung thi tra ve true, nguoc lai tra ve false
        public bool IsCorrectSelection()
        {
            if (isChecked == false)
                return false;
            return (iUserAnswer == iCorrectAnswer) ? true : false;
        }


        //Event khi radio button duoc chon.Tim xem radio button ay o vi tri thu may trong rdlOptions
        // vi tri cua no trong rdlOptions chinh la iUserAnswer (chinh la lua chon cua nguoi dung)
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioBtn = sender as RadioButton;
            if (radioBtn == null)
                return;

            iUserAnswer = rdlOptions.IndexOf(radioBtn) + 1;
            isChecked = true;
        }

        //Sua loi sai
        public void Fix()
        {
            if (IsCorrectSelection())
                return;
            int i = iUserAnswer;
            rdlOptions[iCorrectAnswer - 1].IsChecked = true;
            iUserAnswer = i;
            if (iUserAnswer > 0)
            {
                SetRadioButtonColor(rdlOptions[iUserAnswer - 1], Colors.Red);
            }
            SetRadioButtonColor(rdlOptions[iCorrectAnswer - 1], Colors.Blue);

            //LockControl();
        }

        public void Restart()
        {
            UnLockControl();

            rdlOptions[iCorrectAnswer - 1].IsChecked = false;
            rdlOptions[iUserAnswer - 1].IsChecked = false;

            SetRadioButtonColor(rdlOptions[iCorrectAnswer - 1], Colors.Black);
            SetRadioButtonColor(rdlOptions[iUserAnswer - 1], Colors.Black);
        }

        private void SetRadioButtonColor(RadioButton rbtnButton, Color color)
        {                 
            rbtnButton.Foreground = new SolidColorBrush(color);                        
        }

        //Khoa control
        public void LockControl()
        {
            if (isLocked)
                return;

            foreach (RadioButton button in rdlOptions)
            {
                button.IsEnabled = false;
            }
        }

        //Mo khoa control
        public void UnLockControl()
        {
            if (!isLocked)
                return;

            foreach (RadioButton button in rdlOptions)
            {
                button.IsEnabled = true;
            }
        }
        #endregion Functions
    }
}
