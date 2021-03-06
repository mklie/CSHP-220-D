﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2D5F49164D529C45FDFEE31B1FDC16A0"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView uxInventoryList;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem uxContextAdd;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem uxContextModify;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem uxContextDelete;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem uxContextShowAll;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem uxContextExit;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem uxFileAdd;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem uxFileModify;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem uxFileDelete;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem uxFileShowAll;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem uxFileExit;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem uxHelpAbout;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxFilter;
        
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
            System.Uri resourceLocater = new System.Uri("/InventoryTracker;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.uxInventoryList = ((System.Windows.Controls.ListView)(target));
            
            #line 13 "..\..\MainWindow.xaml"
            this.uxInventoryList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.uxInventoryList_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 13 "..\..\MainWindow.xaml"
            this.uxInventoryList.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.GridViewColumnHeaderClickedHandler));
            
            #line default
            #line hidden
            
            #line 13 "..\..\MainWindow.xaml"
            this.uxInventoryList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.uxInventoryList_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.uxContextAdd = ((System.Windows.Controls.MenuItem)(target));
            
            #line 36 "..\..\MainWindow.xaml"
            this.uxContextAdd.Click += new System.Windows.RoutedEventHandler(this.uxFileAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.uxContextModify = ((System.Windows.Controls.MenuItem)(target));
            
            #line 37 "..\..\MainWindow.xaml"
            this.uxContextModify.Click += new System.Windows.RoutedEventHandler(this.uxFileModify_Click);
            
            #line default
            #line hidden
            
            #line 37 "..\..\MainWindow.xaml"
            this.uxContextModify.Loaded += new System.Windows.RoutedEventHandler(this.uxFileModify_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.uxContextDelete = ((System.Windows.Controls.MenuItem)(target));
            
            #line 38 "..\..\MainWindow.xaml"
            this.uxContextDelete.Click += new System.Windows.RoutedEventHandler(this.uxFileDelete_Click);
            
            #line default
            #line hidden
            
            #line 38 "..\..\MainWindow.xaml"
            this.uxContextDelete.Loaded += new System.Windows.RoutedEventHandler(this.uxFileDelete_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.uxContextShowAll = ((System.Windows.Controls.MenuItem)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.uxContextShowAll.Click += new System.Windows.RoutedEventHandler(this.uxFileShowAll_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.uxContextExit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 43 "..\..\MainWindow.xaml"
            this.uxContextExit.Click += new System.Windows.RoutedEventHandler(this.uxFileExit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.uxFileAdd = ((System.Windows.Controls.MenuItem)(target));
            
            #line 51 "..\..\MainWindow.xaml"
            this.uxFileAdd.Click += new System.Windows.RoutedEventHandler(this.uxFileAdd_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.uxFileModify = ((System.Windows.Controls.MenuItem)(target));
            
            #line 52 "..\..\MainWindow.xaml"
            this.uxFileModify.Click += new System.Windows.RoutedEventHandler(this.uxFileModify_Click);
            
            #line default
            #line hidden
            
            #line 52 "..\..\MainWindow.xaml"
            this.uxFileModify.Loaded += new System.Windows.RoutedEventHandler(this.uxFileModify_Loaded);
            
            #line default
            #line hidden
            return;
            case 9:
            this.uxFileDelete = ((System.Windows.Controls.MenuItem)(target));
            
            #line 53 "..\..\MainWindow.xaml"
            this.uxFileDelete.Click += new System.Windows.RoutedEventHandler(this.uxFileDelete_Click);
            
            #line default
            #line hidden
            
            #line 53 "..\..\MainWindow.xaml"
            this.uxFileDelete.Loaded += new System.Windows.RoutedEventHandler(this.uxFileDelete_Loaded);
            
            #line default
            #line hidden
            return;
            case 10:
            this.uxFileShowAll = ((System.Windows.Controls.MenuItem)(target));
            
            #line 54 "..\..\MainWindow.xaml"
            this.uxFileShowAll.Click += new System.Windows.RoutedEventHandler(this.uxFileShowAll_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.uxFileExit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.uxFileExit.Click += new System.Windows.RoutedEventHandler(this.uxFileExit_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.uxHelpAbout = ((System.Windows.Controls.MenuItem)(target));
            
            #line 63 "..\..\MainWindow.xaml"
            this.uxHelpAbout.Click += new System.Windows.RoutedEventHandler(this.uxHelpAbout_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.uxFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\MainWindow.xaml"
            this.uxFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtFilter_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

