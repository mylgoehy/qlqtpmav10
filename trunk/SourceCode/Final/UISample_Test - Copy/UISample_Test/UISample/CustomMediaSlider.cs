using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;

namespace UISample
{
    public class CustomMediaSlider : System.Windows.Controls.Slider
    {
        public CustomMediaSlider()
            : base()
        {
            DefaultStyleKey = typeof(CustomMediaSlider);
        }

        public event EventHandler ThumbDragStarted;
        public event EventHandler ThumbDragCompleted;
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            //Set up drag event handlers
            Thumb thumb = this.GetTemplateChild("HorizontalThumb") as Thumb; if (thumb != null)
            {
                thumb.DragStarted += new DragStartedEventHandler(thumb_DragStarted);
                thumb.DragCompleted += new DragCompletedEventHandler(thumb_DragCompleted);
            }
        }
        void thumb_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            OnThumbDragCompleted(this, new EventArgs());
        }
        void thumb_DragStarted(object sender, DragStartedEventArgs e)
        {
            OnThumbDragStarted(this, new EventArgs());
        }
        public virtual void OnThumbDragStarted(object sender, EventArgs e)
        {
            if (ThumbDragStarted != null)
                ThumbDragStarted(sender, e);
        }
        protected virtual void OnThumbDragCompleted(object sender, EventArgs e)
        {
            if (ThumbDragCompleted != null)
                ThumbDragCompleted(sender, e);
        }
    }
}
