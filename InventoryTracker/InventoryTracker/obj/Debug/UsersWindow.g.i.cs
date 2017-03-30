﻿#pragma checksum "..\..\UsersWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "433045324DB268582717641C9F03A534"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using InventoryTracker;
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


namespace InventoryTracker {
    
    
    /// <summary>
    /// UsersWindow
    /// </summary>
    public partial class UsersWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid uxUserGrid;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxUsername;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxPassword;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxConfirmPassword;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox uxAdminPrivilege;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uxAddUser;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uxCancelUser;
        
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
            System.Uri resourceLocater = new System.Uri("/InventoryTracker;component/userswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UsersWindow.xaml"
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
            
            #line 10 "..\..\UsersWindow.xaml"
            ((InventoryTracker.UsersWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.uxUserGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.uxUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.uxPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.uxConfirmPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.uxAdminPrivilege = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.uxAddUser = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\UsersWindow.xaml"
            this.uxAddUser.Click += new System.Windows.RoutedEventHandler(this.uxAddUser_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.uxCancelUser = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\UsersWindow.xaml"
            this.uxCancelUser.Click += new System.Windows.RoutedEventHandler(this.uxCancelUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

