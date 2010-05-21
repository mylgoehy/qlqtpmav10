#pragma checksum "C:\Users\Ninh\Desktop\qlqt3\DesignTemplate\UISample\UISample\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5CA8F6E36E8660B364BA00C680A53D1D"
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
using MyControlLibrary;
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
        
        internal System.Windows.Media.Animation.Storyboard strbShowNewVocabolary;
        
        internal System.Windows.Media.Animation.Storyboard strbShowNewVocabolaryReverse;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ScrollViewer scvMain;
        
        internal System.Windows.Controls.Grid grdMain;
        
        internal System.Windows.Shapes.Rectangle rctTop;
        
        internal System.Windows.Shapes.Rectangle rctBottom;
        
        internal System.Windows.Controls.TextBlock txbLearningEng;
        
        internal System.Windows.Controls.TextBlock txbGrade10;
        
        internal System.Windows.Controls.Canvas cnvAllControl;
        
        internal System.Windows.Controls.Grid grdDescription;
        
        internal System.Windows.Shapes.Rectangle rctDesc;
        
        internal System.Windows.Controls.TextBlock txbDesc;
        
        internal System.Windows.Controls.Grid grdSection;
        
        internal System.Windows.Shapes.Rectangle rctSection;
        
        internal System.Windows.Controls.TextBlock txbChooseSection;
        
        internal UISample.MyButton mbtReading;
        
        internal UISample.MyButton mbtListening;
        
        internal UISample.MyButton mbtSpeaking;
        
        internal UISample.MyButton mbtGrammar;
        
        internal UISample.MyButton mbtLanguageFocus;
        
        internal System.Windows.Controls.Grid grdUnit;
        
        internal System.Windows.Shapes.Rectangle rctUnit;
        
        internal UISample.MyButton mbtUnit1;
        
        internal UISample.MyButton mbtUnit2;
        
        internal UISample.MyButton mbtUnit3;
        
        internal UISample.MyButton mbtUnit4;
        
        internal UISample.MyButton mbtUnit5;
        
        internal UISample.MyButton mbtUnit6;
        
        internal UISample.MyButton mbtUnit7;
        
        internal UISample.MyButton mbtUnit8;
        
        internal UISample.MyButton mbtUnit9;
        
        internal UISample.MyButton mbtUnit10;
        
        internal UISample.MyButton mbtUnit11;
        
        internal UISample.MyButton mbtUnit12;
        
        internal UISample.MyButton mbtUnit13;
        
        internal UISample.MyButton mbtUnit14;
        
        internal UISample.MyButton mbtUnit15;
        
        internal UISample.MyButton mbtUnit16;
        
        internal System.Windows.Shapes.Rectangle rctLeft;
        
        internal System.Windows.Controls.Canvas cnvReading;
        
        internal System.Windows.Shapes.Rectangle rctReadingContent;
        
        internal System.Windows.Controls.TextBlock txbReadingTitle;
        
        internal System.Windows.Controls.Button btnTriangle;
        
        internal System.Windows.Controls.Button bntPractice;
        
        internal System.Windows.Controls.Button bntEnglish;
        
        internal System.Windows.Controls.Button bntVietnam;
        
        internal Liquid.RichTextBox rtbxReading;
        
        internal MyControlLibrary.ReadingPracticeControl rpcReadingPractice;
        
        internal System.Windows.Controls.TextBlock txbReadingTitle_Copy;
        
        internal System.Windows.Controls.Button bnt_New_Vocabulary;
        
        internal System.Windows.Controls.DataGrid dg_NewVocabulary;
        
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
            this.strbShowNewVocabolary = ((System.Windows.Media.Animation.Storyboard)(this.FindName("strbShowNewVocabolary")));
            this.strbShowNewVocabolaryReverse = ((System.Windows.Media.Animation.Storyboard)(this.FindName("strbShowNewVocabolaryReverse")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.scvMain = ((System.Windows.Controls.ScrollViewer)(this.FindName("scvMain")));
            this.grdMain = ((System.Windows.Controls.Grid)(this.FindName("grdMain")));
            this.rctTop = ((System.Windows.Shapes.Rectangle)(this.FindName("rctTop")));
            this.rctBottom = ((System.Windows.Shapes.Rectangle)(this.FindName("rctBottom")));
            this.txbLearningEng = ((System.Windows.Controls.TextBlock)(this.FindName("txbLearningEng")));
            this.txbGrade10 = ((System.Windows.Controls.TextBlock)(this.FindName("txbGrade10")));
            this.cnvAllControl = ((System.Windows.Controls.Canvas)(this.FindName("cnvAllControl")));
            this.grdDescription = ((System.Windows.Controls.Grid)(this.FindName("grdDescription")));
            this.rctDesc = ((System.Windows.Shapes.Rectangle)(this.FindName("rctDesc")));
            this.txbDesc = ((System.Windows.Controls.TextBlock)(this.FindName("txbDesc")));
            this.grdSection = ((System.Windows.Controls.Grid)(this.FindName("grdSection")));
            this.rctSection = ((System.Windows.Shapes.Rectangle)(this.FindName("rctSection")));
            this.txbChooseSection = ((System.Windows.Controls.TextBlock)(this.FindName("txbChooseSection")));
            this.mbtReading = ((UISample.MyButton)(this.FindName("mbtReading")));
            this.mbtListening = ((UISample.MyButton)(this.FindName("mbtListening")));
            this.mbtSpeaking = ((UISample.MyButton)(this.FindName("mbtSpeaking")));
            this.mbtGrammar = ((UISample.MyButton)(this.FindName("mbtGrammar")));
            this.mbtLanguageFocus = ((UISample.MyButton)(this.FindName("mbtLanguageFocus")));
            this.grdUnit = ((System.Windows.Controls.Grid)(this.FindName("grdUnit")));
            this.rctUnit = ((System.Windows.Shapes.Rectangle)(this.FindName("rctUnit")));
            this.mbtUnit1 = ((UISample.MyButton)(this.FindName("mbtUnit1")));
            this.mbtUnit2 = ((UISample.MyButton)(this.FindName("mbtUnit2")));
            this.mbtUnit3 = ((UISample.MyButton)(this.FindName("mbtUnit3")));
            this.mbtUnit4 = ((UISample.MyButton)(this.FindName("mbtUnit4")));
            this.mbtUnit5 = ((UISample.MyButton)(this.FindName("mbtUnit5")));
            this.mbtUnit6 = ((UISample.MyButton)(this.FindName("mbtUnit6")));
            this.mbtUnit7 = ((UISample.MyButton)(this.FindName("mbtUnit7")));
            this.mbtUnit8 = ((UISample.MyButton)(this.FindName("mbtUnit8")));
            this.mbtUnit9 = ((UISample.MyButton)(this.FindName("mbtUnit9")));
            this.mbtUnit10 = ((UISample.MyButton)(this.FindName("mbtUnit10")));
            this.mbtUnit11 = ((UISample.MyButton)(this.FindName("mbtUnit11")));
            this.mbtUnit12 = ((UISample.MyButton)(this.FindName("mbtUnit12")));
            this.mbtUnit13 = ((UISample.MyButton)(this.FindName("mbtUnit13")));
            this.mbtUnit14 = ((UISample.MyButton)(this.FindName("mbtUnit14")));
            this.mbtUnit15 = ((UISample.MyButton)(this.FindName("mbtUnit15")));
            this.mbtUnit16 = ((UISample.MyButton)(this.FindName("mbtUnit16")));
            this.rctLeft = ((System.Windows.Shapes.Rectangle)(this.FindName("rctLeft")));
            this.cnvReading = ((System.Windows.Controls.Canvas)(this.FindName("cnvReading")));
            this.rctReadingContent = ((System.Windows.Shapes.Rectangle)(this.FindName("rctReadingContent")));
            this.txbReadingTitle = ((System.Windows.Controls.TextBlock)(this.FindName("txbReadingTitle")));
            this.btnTriangle = ((System.Windows.Controls.Button)(this.FindName("btnTriangle")));
            this.bntPractice = ((System.Windows.Controls.Button)(this.FindName("bntPractice")));
            this.bntEnglish = ((System.Windows.Controls.Button)(this.FindName("bntEnglish")));
            this.bntVietnam = ((System.Windows.Controls.Button)(this.FindName("bntVietnam")));
            this.rtbxReading = ((Liquid.RichTextBox)(this.FindName("rtbxReading")));
            this.rpcReadingPractice = ((MyControlLibrary.ReadingPracticeControl)(this.FindName("rpcReadingPractice")));
            this.txbReadingTitle_Copy = ((System.Windows.Controls.TextBlock)(this.FindName("txbReadingTitle_Copy")));
            this.bnt_New_Vocabulary = ((System.Windows.Controls.Button)(this.FindName("bnt_New_Vocabulary")));
            this.dg_NewVocabulary = ((System.Windows.Controls.DataGrid)(this.FindName("dg_NewVocabulary")));
        }
    }
}
