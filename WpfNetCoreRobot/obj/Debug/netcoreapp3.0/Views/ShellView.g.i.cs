﻿#pragma checksum "..\..\..\..\Views\ShellView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0564CFA99217AF936C19CCCFED808DAE65E703EF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Controls.Ribbon;
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
using WpfNetCoreRobot.Views;


namespace WpfNetCoreRobot.Views {
    
    
    /// <summary>
    /// ShellView
    /// </summary>
    public partial class ShellView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView CoordsListView;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Move;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Left;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Right;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView CommandsListView;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextCommand;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EnterCommand;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RunAllCommands;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfNetCoreRobot;component/views/shellview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ShellView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CoordsListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.Move = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.Left = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.Right = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.CommandsListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.TextCommand = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.EnterCommand = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.RunAllCommands = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
