﻿#pragma checksum "..\..\..\Project\login.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "92F7B9789C73B62CC86074D4053C36C84806E84118A13A05C61FE3262898DB7A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using System.Windows.Shell;
using pr7.Project;


namespace pr7.Project {
    
    
    /// <summary>
    /// login
    /// </summary>
    public partial class login : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Project\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Project\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Project\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Login_in;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/pr7;component/project/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Project\login.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Login = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\Project\login.xaml"
            this.Login.GotFocus += new System.Windows.RoutedEventHandler(this.login_GotFocus);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Project\login.xaml"
            this.Login.LostFocus += new System.Windows.RoutedEventHandler(this.login_LostFocus);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Project\login.xaml"
            this.Login.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Login_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 13 "..\..\..\Project\login.xaml"
            this.PasswordBox.GotFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_GotFocus_1);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Project\login.xaml"
            this.PasswordBox.LostFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_LostFocus_2);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Login_in = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Project\login.xaml"
            this.Login_in.Click += new System.Windows.RoutedEventHandler(this.Login_in_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

