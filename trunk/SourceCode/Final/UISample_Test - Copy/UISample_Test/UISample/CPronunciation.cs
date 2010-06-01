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
    public class CPronunciation : UserControl
    {
        public List<string> Noidung;
        public List<CItem> ListWord = new List<CItem>();
        public List<string> ListSentence = new List<string>();
        public void ReadXML(string pathfile)
        {
            
            if (ListWord.Count() > 0)
                ListWord.Clear();
            if (ListSentence.Count() > 0)
                ListSentence.Clear();

            XDocument myXML = XDocument.Load(pathfile);

            Noidung = (from s in myXML.Descendants("Content") select s.Value).ToList();
            Noidung.Single();
            ListWord = (from s in myXML.Descendants("Item")
                        select new CItem()
                        {
                            type = s.Attribute("type").Value,
                            soundPath = s.Attribute("soundPath").Value,
                            word = s.Value
                        }
                        ).ToList();
            ListSentence = (from s in myXML.Descendants("Sentence") select s.Value).ToList();
        }
        public CPronunciation()
        {
        }
        ~CPronunciation()
        {
        }
    }
}
