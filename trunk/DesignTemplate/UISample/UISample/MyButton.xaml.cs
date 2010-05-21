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
    public partial class MyButton : UserControl
    {
        int id;
        int iGroup;
        static Rectangle rctCurrentUnit;
        static int iCurrentUnit;
        static Rectangle rctCurrentSkill;
        static int iCurrentSkill;
        public MyButton()
        {
            InitializeComponent();

            rctCurrentSkill = null;
            rctCurrentUnit = null;
            id = 0;
            iCurrentUnit = 0;
            iCurrentSkill = 0;
        }
        private void rct_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagReading)
            Rectangle rct = (Rectangle)sender;
            if(id != iCurrentUnit && id < 17)
                rct.Opacity = 0;
            if (id != iCurrentSkill && id > 16)
                rct.Opacity = 0;
            if (id == 0)
                rct.Opacity = 0.0;
        }
        private void rct_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            //if(flagReading)
            //txb.Text = "hihi";
            rct.Opacity = 0.5;
        }
        private void rct_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Rectangle rct = (Rectangle)sender;
            if (id < 17)
            {
                if (iCurrentUnit > 0)
                {
                    rctCurrentUnit.Opacity = 0.0;
                }
                rctCurrentUnit = rct;
                rct.Opacity = 0.5;
                iCurrentUnit = id;
            }
            else
            {
                if (iCurrentSkill > 0)
                {
                    rctCurrentSkill.Opacity = 0.0;
                }
                rctCurrentSkill = rct;
                rct.Opacity = 0.5;
                iCurrentSkill = id;
            }
        }

       

        public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(
        "myText", typeof(string),
        typeof(MyButton), null
        );
        public string myText
        {
            get { return txb.Text; }
            set { txb.Text = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int Group
        {
            get { return iGroup; }
            set { iGroup = value; }
        }

    }
}
