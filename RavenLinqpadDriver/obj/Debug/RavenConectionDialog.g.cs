﻿#pragma checksum "..\..\RavenConectionDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "695EE700541E106749A30EF74BBC8DC8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace RavenLinqpadDriver {
    
    
    /// <summary>
    /// RavenConectionDialog
    /// </summary>
    public partial class RavenConectionDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\RavenConectionDialog.xaml"
        internal System.Windows.Controls.TextBlock textBlock1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\RavenConectionDialog.xaml"
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\RavenConectionDialog.xaml"
        internal System.Windows.Controls.TextBlock textBlock999;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\RavenConectionDialog.xaml"
        internal System.Windows.Controls.TextBox txtUrl;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\RavenConectionDialog.xaml"
        internal System.Windows.Controls.TextBox txtDatabase;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RavenConectionDialog.xaml"
        internal System.Windows.Controls.TextBox txtResourceManagerId;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\RavenConectionDialog.xaml"
        internal System.Windows.Controls.TextBox txtUsername;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\RavenConectionDialog.xaml"
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\RavenConectionDialog.xaml"
        internal System.Windows.Controls.TextBlock textBlock2;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\RavenConectionDialog.xaml"
        internal System.Windows.Controls.TextBlock textBlock3;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\RavenConectionDialog.xaml"
        internal System.Windows.Controls.TextBlock textBlock4;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\RavenConectionDialog.xaml"
        internal System.Windows.Controls.TextBlock textBlock5;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\RavenConectionDialog.xaml"
        internal System.Windows.Controls.Button btnOK;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/RavenLinqpadDriver;component/ravenconectiondialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RavenConectionDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textBlock999 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.txtUrl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtDatabase = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtResourceManagerId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.textBlock4 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.textBlock5 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.btnOK = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\RavenConectionDialog.xaml"
            this.btnOK.Click += new System.Windows.RoutedEventHandler(this.btnOK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

