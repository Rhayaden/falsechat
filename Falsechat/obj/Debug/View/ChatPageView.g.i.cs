﻿#pragma checksum "..\..\..\View\ChatPageView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "18BE806C8157CE7C3761D8F69AC28E64F6CA85EF94C213A661611A42E9E9F2DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Falsechat.View;
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


namespace Falsechat.View {
    
    
    /// <summary>
    /// ChatPageView
    /// </summary>
    public partial class ChatPageView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\View\ChatPageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl Chat;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\View\ChatPageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer ChatScroll;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\View\ChatPageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MessageTextBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\View\ChatPageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MessagePlaceHolder;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\View\ChatPageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MessageLengthWarner;
        
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
            System.Uri resourceLocater = new System.Uri("/Falsechat;component/view/chatpageview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ChatPageView.xaml"
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
            
            #line 15 "..\..\..\View\ChatPageView.xaml"
            ((System.Windows.Controls.ScrollViewer)(target)).ScrollChanged += new System.Windows.Controls.ScrollChangedEventHandler(this.ScrollViewer_ScrollChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Chat = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 3:
            this.ChatScroll = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 4:
            this.MessageTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\View\ChatPageView.xaml"
            this.MessageTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.MessageTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MessagePlaceHolder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.MessageLengthWarner = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

