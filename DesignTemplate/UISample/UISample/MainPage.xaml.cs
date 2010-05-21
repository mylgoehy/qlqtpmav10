using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



namespace UISample
{
	public partial class MainPage : UserControl
	{
        ServiceReference1.Service123Client client = new ServiceReference1.Service123Client();
        int iCurrentUnit;
        bool flagShowButtonVoca = false;
        public MainPage()
        {
            // Required to initialize variables
            InitializeComponent();
            strbShowUnitGrid.Begin();
            iCurrentUnit = 1;
            //===moi them vao===//
            rtbxReading.IsReadOnly = true;
            rtbxReading.Visibility = Visibility.Collapsed;

            //scvMain.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
            //scvMain.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;

            //load practice control
            rpcReadingPractice.LoadContentFromXml("Data/Reading/Practice/reading_practice_3.xml");
            rpcReadingPractice.TittleAlignment(TextAlignment.Left);
            rpcReadingPractice.Visibility = Visibility.Collapsed;

        }
		
		private void btnTriangle_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            strbShowReadingContentReverse.Begin();
            if (flagShowButtonVoca == true)
            {
                strbShowNewVocabolaryReverse.Begin();
                bnt_New_Vocabulary.Content = "Vocabulary";
                flagShowButtonVoca = false;
            }
		}

        private void bntVietnam_Click(object sender, RoutedEventArgs e)
        {
            rtbxReading.RichText = "Đây là RichTextBox mình vừa add dll vào. H mọi người code phần reading trên canvas này nhe. Có thiếu control ji cứ thêm vào. Nhóm Design sẽ chỉnh sửa lại sao. Nếu ko có ji thì đừng nên &#xd;&#xa;dịch chuyển vị trí các control nhe(amination chạy loạn á mà).&#xd;&#xa;&#xd;&#xa;À 1 vấn đề là khi hiển thị thì phan nội dung bên phải cửa sổ chương trình nó vẫn hiện lên=&gt; nên khi chạy nhin thay hết canvas Reading (xấu lắm). Tụi mình chưa sửa dc nên dùng 1 rectangle màu đen che đỡ. Bạn nao biết chỉ dùm lun.&#xd;&#xa;Thank all.";
            rtbxReading.Visibility = Visibility.Visible;
            rpcReadingPractice.Visibility = Visibility.Collapsed;
        }

        private void bntEnglish_Click(object sender, RoutedEventArgs e)
        {
            rtbxReading.RichTextURL = "Data/Reading/Text/RichText.xml";//sau nay truyen vao ten file chua bai reading.
            rtbxReading.Visibility = Visibility.Visible;

            rpcReadingPractice.Visibility = Visibility.Collapsed;
        }

        private void bntPractice_Click(object sender, RoutedEventArgs e)
        {
            rpcReadingPractice.Visibility = Visibility.Visible;
            rtbxReading.Visibility = Visibility.Collapsed;
        }

        private void mbt_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Storyboard sb = (this.Resources["strbShowReadingContent"] as Storyboard);
            sb.Begin();
        }

        public void client_GetVocabularyCompleted(object sender,ServiceReference1.GetVocabularyCompletedEventArgs e)
        {
            dg_NewVocabulary.ItemsSource = e.Result.ToList();
        }

        private void mbtUnit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyButton mbt = (MyButton)sender;
            if (mbt.ID > 0)
            {
                iCurrentUnit = mbt.ID;
            }
        }

        private void bnt_New_Vocabulary_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (flagShowButtonVoca == false)
            {
                strbShowNewVocabolary.Begin();
                bnt_New_Vocabulary.Content = "Close Vocabulary";
                flagShowButtonVoca = true;
            }
            else
            {
                strbShowNewVocabolaryReverse.Begin();
                bnt_New_Vocabulary.Content = "Vocabulary";
                flagShowButtonVoca = false;
            }
            client.GetVocabularyCompleted += new EventHandler<ServiceReference1.GetVocabularyCompletedEventArgs>(client_GetVocabularyCompleted);
            
            client.GetVocabularyAsync(iCurrentUnit);
        }

	}
}
