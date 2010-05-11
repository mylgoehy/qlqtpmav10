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
		
		//unit 1
		private void rctUnit1_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
            if (flagUnit1)
                rctUnit1.Opacity = 0;
		}

		private void rctUnit1_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
            if (flagUnit1)
                rctUnit1.Opacity = 0.5;
		}
		
		private void rctUnit1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
            //strbShowUnitGrid.AutoReverse = true;
            rctUnit1.Opacity = 0.5;
            rctUnit2.Opacity = 0;
            rctUnit3.Opacity = 0;
            flagUnit1 = false;
            flagUnit2 = true;
            flagUnit3 = true;
		}
		
		//unit 2
		private void rctUnit2_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
            if (flagUnit2)
                rctUnit2.Opacity = 0;
		}

		private void rctUnit2_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
            if (flagUnit2)
                rctUnit2.Opacity = 0.5;
		}
		
		private void rctUnit2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
            rctUnit2.Opacity = 0.5;
            rctUnit1.Opacity = 0;
            rctUnit3.Opacity = 0;
            flagUnit2 = false;
            flagUnit1 = true;
            flagUnit3 = true;
		}
		
		//unit 3
		private void rctUnit3_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
            if (flagUnit3)
                rctUnit3.Opacity = 0;
		}
		
		private void rctUnit3_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
            if (flagUnit3)
                rctUnit3.Opacity = 0.5;
		}

		private void rctUnit3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
            rctUnit3.Opacity = 0.5;
            rctUnit1.Opacity = 0;
            rctUnit2.Opacity = 0;
            flagUnit3 = false;
            flagUnit1 = true;
            flagUnit2 = true;
		}
		private void btnTriangle_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
            cnvReading.Opacity = 0;
            strbShowReadingContentReverse.Begin();
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
	}
}