#pragma checksum "D:\Tai lieu\2009\qlqtpm\Documents\UISample\UISample\Page1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B12FAEF77D5BF0646912517DCAF81FCF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace UISample {
    
    
    public partial class Page1 : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock txbTitle1;
        
        internal System.Windows.Controls.TextBlock txbTitle2;
        
        internal System.Windows.Controls.TextBlock txbUserText;
        
        internal System.Windows.Controls.TextBlock txbPassText;
        
        internal System.Windows.Controls.TextBlock txbInform;
        
        internal System.Windows.Controls.Button btnLogin;
        
        internal System.Windows.Controls.TextBox txtUser;
        
        internal System.Windows.Controls.PasswordBox pwbPassword;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/UISample;component/Page1.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txbTitle1 = ((System.Windows.Controls.TextBlock)(this.FindName("txbTitle1")));
            this.txbTitle2 = ((System.Windows.Controls.TextBlock)(this.FindName("txbTitle2")));
            this.txbUserText = ((System.Windows.Controls.TextBlock)(this.FindName("txbUserText")));
            this.txbPassText = ((System.Windows.Controls.TextBlock)(this.FindName("txbPassText")));
            this.txbInform = ((System.Windows.Controls.TextBlock)(this.FindName("txbInform")));
            this.btnLogin = ((System.Windows.Controls.Button)(this.FindName("btnLogin")));
            this.txtUser = ((System.Windows.Controls.TextBox)(this.FindName("txtUser")));
            this.pwbPassword = ((System.Windows.Controls.PasswordBox)(this.FindName("pwbPassword")));
        }
    }
}
