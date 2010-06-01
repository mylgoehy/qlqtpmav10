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
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace UISample
{
    public partial class UnitControl : UserControl
    {
        private StackPanel stpPanel;

        //private RoutedEventHandler unitButtonControlClickHandler;

        List<HighlightButton> btnlUnits;

        RadioButton selectedButton;

        private int iUnit = 0;

        public int Unit { get { return iUnit; } }

        public UnitControl()
        {
            InitializeComponent();

            stpPanel = new StackPanel();

            stpPanel.VerticalAlignment = VerticalAlignment.Stretch;

            stpPanel.Background = new SolidColorBrush(Color.FromArgb(0,255,255,255));

            LayoutRoot.Content = stpPanel;

            btnlUnits = new List<HighlightButton>();

            selectedButton = null;
        }

        public void AddUnit(int number)
        {
            if (number <= 0)
                return;

            int count = btnlUnits.Count;
            string strFormat = "Unit {0}";

            for (int i = 0; i < number; ++i)
            {
                HighlightButton btnUnit = new HighlightButton();

                btnUnit.button.Content = string.Format(strFormat, count + 1);

                btnUnit.button.GroupName = "UnitControlGroup";

                btnUnit.Name = string.Format("btnUnit_{0}", count + 1);
                btnUnit.button.Name = string.Format("btnUnit_{0}", count + 1);
                btnUnit.button.Tag = (int)(count + 1);

                Binding binding = new Binding();
                //binding.BindsDirectlyToSource = true;
                binding.Mode = BindingMode.OneWay;
                binding.Path = new PropertyPath("FontSize");
                binding.Source = this.LayoutRoot;


                btnUnit.button.SetBinding(HighlightButton.FontSizeProperty, binding);
                //btnUnit.SetBinding(HighlightButton.FontSizeProperty, binding);

                btnUnit.button.Click += new RoutedEventHandler(UnitButtonControl_Click);

                btnlUnits.Add(btnUnit);

                stpPanel.Children.Add(btnUnit);

                ++count;
            }

            double d = LayoutRoot.FontSize;
        }

        private void LayoutRoot_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
        	// TODO: Add event handler implementation here.

            ScrollViewer scrollViewer = sender as ScrollViewer;

            if (scrollViewer == null)
                return;
            

            if (e.Delta > 0)
                scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - 20.00);

            if (e.Delta < 0)
                scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset + 20.00);
        }

        private void UnitButtonControl_Click(object sender, RoutedEventArgs e)
        {
            RadioButton rbtnUnit = sender as RadioButton;

            if (rbtnUnit == null)
                return;

            if(selectedButton != null)
                selectedButton.Foreground = new SolidColorBrush(Colors.White);

            rbtnUnit.Foreground = new SolidColorBrush(Colors.Cyan);
            
            iUnit = (int)rbtnUnit.Tag;

            selectedButton = rbtnUnit;
        }
    }

    
}
