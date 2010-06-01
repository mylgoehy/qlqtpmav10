using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Xml;

namespace UISample
{
    public partial class PracticeControl : UserControl
    {
        Canvas cnvMain;

        List<SelectionPartControl> spcList;
        List<FillInBlankControl> fbcList;
        List<Grid> grdPageList;
        int iCurPage;
        int iNumPage;


        public PracticeControl()
        {
            InitializeComponent();

            cnvMain = new Canvas();
            spcList = new List<SelectionPartControl>();
            fbcList = new List<FillInBlankControl>();
            grdPageList = new List<Grid>();
            LayoutRoot.Content = cnvMain;
            iCurPage = 0;
            iNumPage = 0;
        }

        //Tải các Task lên ,tham so gom:
        //  streams: chứa dữ liệu xml (file xml dưới dạng binary).
        //  types: chứa loại bài tập của task đó là gì.
        public void AddPractices(List<Stream> streams,List<int> types)
        {
            if (streams == null)
                return;

            ResetAll();

            SelectionPartControl control = new SelectionPartControl();
            Stream stream;

            for (int i = 0; i < streams.Count; ++i)
            {
                stream = streams[i];

                switch (types[0])
                {
                    case 0:
                        {
                            control = new SelectionPartControl();

                            control.LoadContentFromStream(stream);

                            cnvMain.Children.Add(control);
                            break;
                        }
                }
            }
            spcList.Add(control);  
        }

        //Tải các Task lên ,tham so gom:
        //  streams: chứa dữ liệu xml (file xml dưới dạng binary).dùng trực tiếp xml để biết loại bài tập
        public void AddPractices(List<Stream> streams)
        {
            if (streams == null)
                return;

            ResetAll();

            
            Stream stream;
            XmlReader reader;
            int type;

            for (int i = 0; i < streams.Count; ++i)
            {
                stream = streams[i];

                //Lấy type từ xml stream
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.CloseInput = false;

                reader = XmlReader.Create(stream,settings);
                if(reader == null)continue;
                if (!reader.ReadToFollowing("Type"))
                    continue;
                type = reader.ReadElementContentAsInt();
                reader.Close();
                stream.Seek(0, SeekOrigin.Begin);

                switch (type)
                {
                        //trac nghiem
                    case 0:
                        {
                            SelectionPartControl control = new SelectionPartControl();
                            control = new SelectionPartControl();

                            control.LoadContentFromStream(stream);

                            cnvMain.Children.Add(control);
                            spcList.Add(control);
                            break;                            
                        }

                        //dien tu
                    case 1:
                        {
                            FillInBlankControl control = new FillInBlankControl();
                            control.LoadContentFromStream(stream);
                            control.Tag = type;
                            fbcList.Add(control);
                            break;
                        }
                }

                stream.Dispose();
            }            
        }

        public void AddPractice(string fileName)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;
            settings.IgnoreWhitespace = true;
            XmlReader reader = XmlReader.Create(fileName, settings);

            reader.MoveToContent();

            if (!reader.ReadToFollowing("Type"))
                return;

            int type = reader.ReadElementContentAsInt();

            Grid grdPage = new Grid();
            cnvMain.Children.Add(grdPage);
            grdPageList.Add(grdPage);
            iNumPage++;

            if (iCurPage == 0)
            {
                grdPage.Visibility = Visibility.Visible;
                iCurPage = 1;
            }
            else
                grdPage.Visibility = Visibility.Collapsed;

            switch (type)
            {
                case 0:
                    {
                        SelectionPartControl control = new SelectionPartControl();
                        control.LoadContentFromXml(fileName);
                        control.Tag = type;
                        grdPage.Children.Add(control);
                        spcList.Add(control);
                        break;
                    }

                case 1:
                    {
                        FillInBlankControl control = new FillInBlankControl();
                        control.LoadContentFromXML(fileName);
                        control.Tag = type;
                        grdPage.Children.Add(control);
                        fbcList.Add(control);
                        break;
                    }
            }
        }

        public void NextPage()
        {
            if (iCurPage < iNumPage)
            {
                grdPageList[iCurPage - 1].Visibility = Visibility.Collapsed;
                iCurPage++;
                grdPageList[iCurPage - 1].Visibility = Visibility.Visible;
            }
        }

        public void PreviousPage()
        {
            if (iCurPage > 1)
            {
                grdPageList[iCurPage - 1].Visibility = Visibility.Collapsed;
                iCurPage--;
                grdPageList[iCurPage - 1].Visibility = Visibility.Visible;
            }
        }

        public bool CanNext()
        {
            if (iCurPage < iNumPage)
                return true;
            else
                return false;
        }

        public bool CanBack()
        {
            if (iCurPage > 0)
                return true;
            else
                return false;
        }

        public void FixWrongSentence()
        {            
            if (iCurPage == 0)
                return;

            SelectionPartControl control = grdPageList[iCurPage - 1].Children[0] as SelectionPartControl;
            if (control != null)
            {
                control.FixWrongSentences();
                return;
            }

            FillInBlankControl fcontrol = grdPageList[iCurPage - 1].Children[0] as FillInBlankControl;
            if (fcontrol != null)
            {
                fcontrol.FixWrongSentences();
                return;
            }


        }
        public void ResetAll()
        {
            spcList.Clear();
            iCurPage = 0;
            iNumPage = 0;
            if (cnvMain.Children.Count != 0)
                cnvMain.Children.Clear();
        }
    }
}
