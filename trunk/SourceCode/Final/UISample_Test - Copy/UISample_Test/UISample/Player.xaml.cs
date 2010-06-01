using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HelloSilverlight
{
	public partial class Player : UserControl
	{
        private bool isSliderTimeLock = false;

        private DispatcherTimer timer = new DispatcherTimer();

        public Uri UriSource
        {
            set
            {
                media.Stop();
                
                media.Source = value;
            }
        }

		public Player()
		{
			// Required to initialize variables
			InitializeComponent();

            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Tick += new EventHandler(timer_Tick);
		}

        void timer_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (media.NaturalDuration.TimeSpan.TotalMilliseconds > 0 && isSliderTimeLock == false)
            {
                txbTime.Text = string.Format("{0:00}:{1:00}",media.Position.Minutes,media.Position.Seconds);
                double d = media.Position.TotalSeconds / media.NaturalDuration.TimeSpan.TotalSeconds;
                sliderTime.Value = d;
            }
        }

		private void PlayButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(media.CurrentState == MediaElementState.Stopped || media.CurrentState == MediaElementState.Paused)
			{
				media.Play();
                PlayButton.IsEnabled = false;
			}
		}

		private void StopButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
            if (media.CurrentState == MediaElementState.Playing || media.CurrentState == MediaElementState.Paused)
			{
				media.Stop();
                PlayButton.IsEnabled = true;
			}
		}

		private void PauseButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(media.CurrentState == MediaElementState.Playing)
			{
				media.Pause();
                PlayButton.IsEnabled = true;
			}
		}

		private void volSlider_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
		{
			// TODO: Add event handler implementation here.
			if(media != null)
			{
				media.Volume = Math.Round(e.NewValue, 2);
				double ld = media.Volume;
				volNum.Text = (Math.Round(ld, 2)*100).ToString() + "%";
				
			}
			
		}

		private void media_MediaOpened(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			volSlider.Value = media.Volume;
            volNum.Text = (Math.Round(media.Volume, 2) * 100).ToString() + "%";
		}

		private void media_BufferingProgressChanged(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}

		private void media_DownloadProgressChanged(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}

		private void media_MediaEnded(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
            PlayButton.IsEnabled = true;
		}

		private void media_CurrentStateChanged(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
            if (media.CurrentState == MediaElementState.Playing)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
		}

		private void sliderTime_ThumbDragCompleted(object sender, System.EventArgs e)
		{
			// TODO: Add event handler implementation here.
            isSliderTimeLock = false;
            media.Position = TimeSpan.FromMilliseconds(media.NaturalDuration.TimeSpan.TotalMilliseconds * sliderTime.Value);
		}

		private void sliderTime_ThumbDragStarted(object sender, System.EventArgs e)
		{
			// TODO: Add event handler implementation here.
            isSliderTimeLock = true;
		}
	}
}