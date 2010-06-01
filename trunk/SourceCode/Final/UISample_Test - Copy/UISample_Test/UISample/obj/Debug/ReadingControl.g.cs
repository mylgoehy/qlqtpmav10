#pragma checksum "C:\Users\Green\Desktop\Final\UISample_Test - Copy\UISample_Test\UISample\ReadingControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F16BCF7EB7097E1FC31BAF5E76D082CA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HelloSilverlight;
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
    
    
    public partial class ReadingControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Rectangle rctBackground;
        
        internal System.Windows.Controls.TextBlock txbTitle;
        
        internal Liquid.RichTextBox rtxtEngReadingText;
        
        internal UISample.PracticeControl rpcReadingPractice;
        
        internal Liquid.RichTextBox rtxtVietReadingText;
        
        internal HelloSilverlight.Player audioPlayer;
        
        internal System.Windows.Controls.Button buttonAnswer;
        
        internal System.Windows.Controls.StackPanel stkpnButtonMenuPanel;
        
        internal System.Windows.Controls.Button bntPractice;
        
        internal System.Windows.Controls.Button bntEnglish;
        
        internal System.Windows.Controls.Button bntVietnam;
        
        internal System.Windows.Controls.Button nextButton;
        
        internal System.Windows.Controls.Button BackButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/UISample;component/ReadingControl.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.rctBackground = ((System.Windows.Shapes.Rectangle)(this.FindName("rctBackground")));
            this.txbTitle = ((System.Windows.Controls.TextBlock)(this.FindName("txbTitle")));
            this.rtxtEngReadingText = ((Liquid.RichTextBox)(this.FindName("rtxtEngReadingText")));
            this.rpcReadingPractice = ((UISample.PracticeControl)(this.FindName("rpcReadingPractice")));
            this.rtxtVietReadingText = ((Liquid.RichTextBox)(this.FindName("rtxtVietReadingText")));
            this.audioPlayer = ((HelloSilverlight.Player)(this.FindName("audioPlayer")));
            this.buttonAnswer = ((System.Windows.Controls.Button)(this.FindName("buttonAnswer")));
            this.stkpnButtonMenuPanel = ((System.Windows.Controls.StackPanel)(this.FindName("stkpnButtonMenuPanel")));
            this.bntPractice = ((System.Windows.Controls.Button)(this.FindName("bntPractice")));
            this.bntEnglish = ((System.Windows.Controls.Button)(this.FindName("bntEnglish")));
            this.bntVietnam = ((System.Windows.Controls.Button)(this.FindName("bntVietnam")));
            this.nextButton = ((System.Windows.Controls.Button)(this.FindName("nextButton")));
            this.BackButton = ((System.Windows.Controls.Button)(this.FindName("BackButton")));
        }
    }
}
