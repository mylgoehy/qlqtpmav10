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

        public MainPage()
        {
            // Required to initialize variables
            InitializeComponent();
            strbShowUnitGrid.Begin();

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
		
        ////unit 1
        //private void rctUnit1_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    // TODO: Add event handler implementation here.
        //    if (flagUnit1)
        //        rctUnit1.Opacity = 0;
        //}

        //private void rctUnit1_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    // TODO: Add event handler implementation here.
        //    if (flagUnit1)
        //        rctUnit1.Opacity = 0.5;
        //}
		
        //private void rctUnit1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    // TODO: Add event handler implementation here.
        //    //strbShowUnitGrid.AutoReverse = true;
        //    rctUnit1.Opacity = 0.5;
        //    rctUnit2.Opacity = 0;
        //    rctUnit3.Opacity = 0;
        //    flagUnit1 = false;
        //    flagUnit2 = true;
        //    flagUnit3 = true;
        //}
		
        ////unit 2
        //private void rctUnit2_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    // TODO: Add event handler implementation here.
        //    if (flagUnit2)
        //        rctUnit2.Opacity = 0;
        //}

        //private void rctUnit2_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    // TODO: Add event handler implementation here.
        //    if (flagUnit2)
        //        rctUnit2.Opacity = 0.5;
        //}
		
        //private void rctUnit2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    // TODO: Add event handler implementation here.
        //    rctUnit2.Opacity = 0.5;
        //    rctUnit1.Opacity = 0;
        //    rctUnit3.Opacity = 0;
        //    flagUnit2 = false;
        //    flagUnit1 = true;
        //    flagUnit3 = true;
        //}
		
        ////unit 3
        //private void rctUnit3_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    // TODO: Add event handler implementation here.
        //    if (flagUnit3)
        //        rctUnit3.Opacity = 0;
        //}
		
        //private void rctUnit3_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    // TODO: Add event handler implementation here.
        //    if (flagUnit3)
        //        rctUnit3.Opacity = 0.5;
        //}

        //private void rctUnit3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    // TODO: Add event handler implementation here.
        //    rctUnit3.Opacity = 0.5;
        //    rctUnit1.Opacity = 0;
        //    rctUnit2.Opacity = 0;
        //    flagUnit3 = false;
        //    flagUnit1 = true;
        //    flagUnit2 = true;
        //}
		private void btnTriangle_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
            //cnvReading.Opacity = 0;
            strbShowReadingContentReverse.Begin();
            strbShowNewVocabolaryReverse.Begin();
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

        private void bnt_New_Vocabulary_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            int a;
            a = 1;
            strbShowNewVocabolary.Begin();
            client.GetVocabularyCompleted += new EventHandler<ServiceReference1.GetVocabularyCompletedEventArgs>(client_GetVocabularyCompleted);
            //can bit dang o bai nao thi load vocabolary bai do len, truyen tham so vao
            //vi du o day la a
            client.GetVocabularyAsync(a);
        }
	}
}
