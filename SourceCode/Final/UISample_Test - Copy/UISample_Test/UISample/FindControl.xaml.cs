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
using System.Collections.Generic;

namespace UISample
{
    public partial class FindControl : UserControl
    {

        private List<string> dataWord;
        private List<string> dataMeaningOfWord;
        public FindControl()
        {
            InitializeComponent();
        }
        public void ItemSource(List<string> word, List<string> meaning)
        {
            dataWord = word;
            dataMeaningOfWord = meaning;
            autocomplexbox.ItemsSource = dataWord;
        }
        public string GetText()
        {
            return autocomplexbox.Text;
        }

        private void autocomplexbox_TextChanged(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            string st = "";  
            for (int i = 0; i < dataWord.Count; i++)
            {
                if (dataWord[i].ToLower().CompareTo(autocomplexbox.Text.ToLower()) == 0)
                    st = st + dataMeaningOfWord[dataWord.IndexOf(autocomplexbox.Text)] + "\n";
            }
            textblock.Text = st;
        }
    }
}
