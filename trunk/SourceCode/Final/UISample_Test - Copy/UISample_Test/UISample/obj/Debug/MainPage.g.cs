#pragma checksum "C:\Users\Green\Desktop\Final\UISample_Test - Copy\UISample_Test\UISample\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D54AB04FD24226E7292F0348A9A2FFDC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Liquid;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using UISample;


namespace UISample {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Media.Animation.Storyboard strbShowUnitGrid;
        
        internal System.Windows.Media.Animation.Storyboard strbShowReadingContent;
        
        internal System.Windows.Media.Animation.Storyboard strbShowReadingContentReverse;
        
        internal System.Windows.Media.Animation.Storyboard strbFindAnimation;
        
        internal System.Windows.Media.Animation.Storyboard strbFindAnimation_Copy1;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ScrollViewer scvLayout;
        
        internal System.Windows.Controls.Grid grdMain;
        
        internal System.Windows.Shapes.Rectangle rctTop;
        
        internal System.Windows.Shapes.Rectangle rctBottom;
        
        internal System.Windows.Controls.TextBlock txbLearningEng;
        
        internal System.Windows.Controls.TextBlock txbGrade10;
        
        internal System.Windows.Controls.Canvas cnvAllControl;
        
        internal System.Windows.Controls.Grid grdDescription;
        
        internal System.Windows.Shapes.Rectangle rctDesc;
        
        internal Liquid.RichTextBlock rtbReviewContent;
        
        internal System.Windows.Controls.Grid grdSection;
        
        internal System.Windows.Shapes.Rectangle rctSection;
        
        internal System.Windows.Controls.TextBlock txbChooseSection;
        
        internal System.Windows.Controls.TextBlock txbReading;
        
        internal System.Windows.Controls.TextBlock txbSpeaking;
        
        internal System.Windows.Controls.TextBlock txbListening;
        
        internal System.Windows.Controls.TextBlock txbWriting;
        
        internal System.Windows.Controls.TextBlock txbLanguageFocus;
        
        internal System.Windows.Shapes.Rectangle rctReading;
        
        internal System.Windows.Shapes.Rectangle rctSpeaking;
        
        internal System.Windows.Shapes.Rectangle rctListening;
        
        internal System.Windows.Shapes.Rectangle rctWriting;
        
        internal System.Windows.Shapes.Rectangle rctLanguageFocus;
        
        internal System.Windows.Controls.Grid grdUnit;
        
        internal System.Windows.Shapes.Rectangle rctUnitBackground;
        
        internal System.Windows.Controls.TextBlock txbChooseUnit;
        
        internal UISample.UnitControl ucUnitList;
        
        internal System.Windows.Shapes.Rectangle rctLeft;
        
        internal System.Windows.Controls.Button btnTriangle;
        
        internal System.Windows.Controls.Canvas cnvContent;
        
        internal UISample.ReadingControl rctrlReadingContent;
        
        internal UISample.ListeningControl lctrlListeningContent;
        
        internal UISample.SpeakingControl sctrlSpeakingContent;
        
        internal UISample.WritingControl wctrlWritingContent;
        
        internal UISample.LanguageFocusControl lfctrlLangFocusContent;
        
        internal System.Windows.Controls.HyperlinkButton hbtnGoogleLink;
        
        internal System.Windows.Controls.Canvas canvas;
        
        internal UISample.FindControl findControl;
        
        internal System.Windows.Controls.Button button;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/UISample;component/MainPage.xaml", System.UriKind.Relative));
            this.strbShowUnitGrid = ((System.Windows.Media.Animation.Storyboard)(this.FindName("strbShowUnitGrid")));
            this.strbShowReadingContent = ((System.Windows.Media.Animation.Storyboard)(this.FindName("strbShowReadingContent")));
            this.strbShowReadingContentReverse = ((System.Windows.Media.Animation.Storyboard)(this.FindName("strbShowReadingContentReverse")));
            this.strbFindAnimation = ((System.Windows.Media.Animation.Storyboard)(this.FindName("strbFindAnimation")));
            this.strbFindAnimation_Copy1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("strbFindAnimation_Copy1")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.scvLayout = ((System.Windows.Controls.ScrollViewer)(this.FindName("scvLayout")));
            this.grdMain = ((System.Windows.Controls.Grid)(this.FindName("grdMain")));
            this.rctTop = ((System.Windows.Shapes.Rectangle)(this.FindName("rctTop")));
            this.rctBottom = ((System.Windows.Shapes.Rectangle)(this.FindName("rctBottom")));
            this.txbLearningEng = ((System.Windows.Controls.TextBlock)(this.FindName("txbLearningEng")));
            this.txbGrade10 = ((System.Windows.Controls.TextBlock)(this.FindName("txbGrade10")));
            this.cnvAllControl = ((System.Windows.Controls.Canvas)(this.FindName("cnvAllControl")));
            this.grdDescription = ((System.Windows.Controls.Grid)(this.FindName("grdDescription")));
            this.rctDesc = ((System.Windows.Shapes.Rectangle)(this.FindName("rctDesc")));
            this.rtbReviewContent = ((Liquid.RichTextBlock)(this.FindName("rtbReviewContent")));
            this.grdSection = ((System.Windows.Controls.Grid)(this.FindName("grdSection")));
            this.rctSection = ((System.Windows.Shapes.Rectangle)(this.FindName("rctSection")));
            this.txbChooseSection = ((System.Windows.Controls.TextBlock)(this.FindName("txbChooseSection")));
            this.txbReading = ((System.Windows.Controls.TextBlock)(this.FindName("txbReading")));
            this.txbSpeaking = ((System.Windows.Controls.TextBlock)(this.FindName("txbSpeaking")));
            this.txbListening = ((System.Windows.Controls.TextBlock)(this.FindName("txbListening")));
            this.txbWriting = ((System.Windows.Controls.TextBlock)(this.FindName("txbWriting")));
            this.txbLanguageFocus = ((System.Windows.Controls.TextBlock)(this.FindName("txbLanguageFocus")));
            this.rctReading = ((System.Windows.Shapes.Rectangle)(this.FindName("rctReading")));
            this.rctSpeaking = ((System.Windows.Shapes.Rectangle)(this.FindName("rctSpeaking")));
            this.rctListening = ((System.Windows.Shapes.Rectangle)(this.FindName("rctListening")));
            this.rctWriting = ((System.Windows.Shapes.Rectangle)(this.FindName("rctWriting")));
            this.rctLanguageFocus = ((System.Windows.Shapes.Rectangle)(this.FindName("rctLanguageFocus")));
            this.grdUnit = ((System.Windows.Controls.Grid)(this.FindName("grdUnit")));
            this.rctUnitBackground = ((System.Windows.Shapes.Rectangle)(this.FindName("rctUnitBackground")));
            this.txbChooseUnit = ((System.Windows.Controls.TextBlock)(this.FindName("txbChooseUnit")));
            this.ucUnitList = ((UISample.UnitControl)(this.FindName("ucUnitList")));
            this.rctLeft = ((System.Windows.Shapes.Rectangle)(this.FindName("rctLeft")));
            this.btnTriangle = ((System.Windows.Controls.Button)(this.FindName("btnTriangle")));
            this.cnvContent = ((System.Windows.Controls.Canvas)(this.FindName("cnvContent")));
            this.rctrlReadingContent = ((UISample.ReadingControl)(this.FindName("rctrlReadingContent")));
            this.lctrlListeningContent = ((UISample.ListeningControl)(this.FindName("lctrlListeningContent")));
            this.sctrlSpeakingContent = ((UISample.SpeakingControl)(this.FindName("sctrlSpeakingContent")));
            this.wctrlWritingContent = ((UISample.WritingControl)(this.FindName("wctrlWritingContent")));
            this.lfctrlLangFocusContent = ((UISample.LanguageFocusControl)(this.FindName("lfctrlLangFocusContent")));
            this.hbtnGoogleLink = ((System.Windows.Controls.HyperlinkButton)(this.FindName("hbtnGoogleLink")));
            this.canvas = ((System.Windows.Controls.Canvas)(this.FindName("canvas")));
            this.findControl = ((UISample.FindControl)(this.FindName("findControl")));
            this.button = ((System.Windows.Controls.Button)(this.FindName("button")));
        }
    }
}
