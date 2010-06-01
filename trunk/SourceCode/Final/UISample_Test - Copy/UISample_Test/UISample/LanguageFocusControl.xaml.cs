using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.IO;

namespace UISample
{
    
	public partial class LanguageFocusControl : UserControl
	{
        //grammar
        public int[] array = { 0, 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 4, 3, 2, 2 };
        public int currentPage = 1;
        public bool flag = false;
        public int SelectedUnit;

        //prononciation
        public string UnitSelected;
        public string pathXML;
        public CPronunciation _unit = new CPronunciation();
        List<Button> words = new List<Button>();
        List<MediaElement> dssound = new List<MediaElement>();

		public LanguageFocusControl()
		{
			// Required to initialize variables
			InitializeComponent();
		}

        //grammar
        public const string SelectedUnitPropertyName = "SelectedUnit";
        public static readonly DependencyProperty SelectedUnitProperty = DependencyProperty.Register(
           SelectedUnitPropertyName,
           typeof(int),
           typeof(LanguageFocusControl),
           new PropertyMetadata(0, OnSelectedUnitChanged));

        private static void OnSelectedUnitChanged(DependencyObject src, DependencyPropertyChangedEventArgs args)
        {
            LanguageFocusControl languageControl = src as LanguageFocusControl;

            if (src == null)
                return;
            
            languageControl.rtb_Grammar.Clear();
            languageControl.rtb_Answer.Clear();
            languageControl.currentPage = 1;
        }
        public void SelectUnitSet(int idUnit)
        {
            SelectedUnit = idUnit;
        }
		private void btnTriangle_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
           
            if (flag == false)
            {
                strb_ShowAnswer.Begin();
                flag = true;
            }
            else
            {
                strb_ShowAnswerReverse.Begin();
                flag = false;
            }
		}
				
		private void bnt_right_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if (currentPage < array[SelectedUnit])
            {
                currentPage++;
                rtb_Grammar.RichTextURL = String.Format(@"Data/Question/Unit{0}_Q{1}.xml", SelectedUnit, currentPage);
                rtb_Answer.RichTextURL = String.Format(@"Data/Answer/Unit{0}_E{1}.xml", SelectedUnit, currentPage);
                tb_Page.Text = currentPage.ToString() + "/" + array[SelectedUnit].ToString();
            }
		}

		private void bnt_left_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if (currentPage > 1)
            {
                currentPage--;
                rtb_Grammar.RichTextURL = String.Format(@"Data/Question/Unit{0}_Q{1}.xml", SelectedUnit, currentPage);
                rtb_Answer.RichTextURL = String.Format(@"Data/Answer/Unit{0}_E{1}.xml", SelectedUnit, currentPage);
                tb_Page.Text = currentPage.ToString() + "/" + array[SelectedUnit].ToString();
            }
		}

		private void bnt_delete_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add  handler imlementation here.
            strb_ShowGrammarReverse.Begin();
          
		}

		private void buttonGrammar_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			currentPage = 1;
            strb_ShowGrammar.Begin();
            tb_Page.Text = currentPage.ToString() + "/" + array[SelectedUnit].ToString();
            rtb_Grammar.RichTextURL = String.Format(@"Data/Question/Unit{0}_Q{1}.xml",SelectedUnit, currentPage);
            rtb_Answer.RichTextURL = String.Format(@"Data/Answer/Unit{0}_E{1}.xml", SelectedUnit,currentPage);

            gridGrammar.Visibility = Visibility.Visible;
            cvMainPronun.Visibility = Visibility.Collapsed;
			
		}

        //pronunciation
        public void loadBK()
        {
            if (words.Count() > 0)
                words.Clear();
            if (dssound.Count() > 0)
                dssound.Clear();

            tlockContent.Text = _unit.Noidung[0].ToString();
            List<string> temp = new List<string>();

            string str;

            for (int i = 1; i < _unit.ListWord.Count; i++)//dem co bao nhieu loai phat am
            {
                int no = 0;
                str = _unit.ListWord[i].type.ToString();
                for (int j = 0; j < temp.Count; j++)
                {
                    if (temp[j].ToString() == str)
                    {
                        no = 1;
                    }
                }
                if (no == 0)
                {
                    temp.Add(str);
                }
            }
            //tao 1 stackpanel co temp.count textlock
            StackPanel stack = new StackPanel();
            stack.Width = cvPronun.Width;
            stack.Height = 15;
            stack.Orientation = Orientation.Horizontal;
            for (int i = 0; i < temp.Count; i++)
            {
                TextBlock txtblock = new TextBlock();
                txtblock.Width = cvPronun.Width / temp.Count();
                txtblock.Height = 15;//= kich thuoc font la chuan 
                txtblock.TextAlignment = TextAlignment.Center;
                txtblock.FontSize = 13;
                txtblock.Text = temp[i].ToString();
                stack.Children.Add(txtblock);
            }
            cvPronun.Children.Add(stack);
            //Them cac word vao

            for (int i = 0; i < _unit.ListWord.Count; i++)
            {
                StackPanel stack1 = new StackPanel();
                stack1.Width = cvPronun.Width - 10;
                stack1.Height = 25;

                stack1.Orientation = Orientation.Horizontal;
                for (int j = 0; j < temp.Count * 2; j++)
                {
                    if (i + j >= _unit.ListWord.Count())
                    {
                        break;
                    }
                    Button mbutton = new Button();
                    mbutton.BorderThickness = new Thickness(0);
                    mbutton.Width = stack1.Width / (temp.Count * 2);
                    mbutton.Height = 25;


                    mbutton.Name = "b" + _unit.ListWord[i + j].word.ToString();
                    mbutton.Content = _unit.ListWord[i + j].word.ToString();


                    mbutton.Click += new RoutedEventHandler(mbutton_Click);
                    stack1.Children.Add(mbutton);
                }
                i = i + temp.Count() * 2 - 1;
                listword.Items.Add(stack1);
            }

            //practise these sentences
            for (int i = 0; i < _unit.ListSentence.Count; i++)
            {
                ListBoxItem item = new ListBoxItem();
                item.FontSize = 12;
                item.Content = _unit.ListSentence[i];
                lbPractise.Items.Add(item);
            }
        }

        void mbutton_Click(object sender, RoutedEventArgs e)
        {

            Button mySelectbutton = sender as Button;
            if (mySelectbutton == null)
                return;
            string str = mySelectbutton.Content.ToString();
            iTem.Source = new Uri(UnitSelected + str + ".mp3", UriKind.Relative);
            iTem.Volume = 1;
            iTem.AutoPlay = true;


        }
        private void bHideShow_Click(object sender, RoutedEventArgs e)
        {
            //xóa danh sách hiện tại

            lbPractise.Items.Clear();
            listword.Items.Clear();
            cvPronun.Children.Clear();
            _unit.ReadXML(pathXML);
            loadBK();

            gridGrammar.Visibility = Visibility.Collapsed;
            cvMainPronun.Visibility = Visibility.Visible;
        }
	}
}