﻿#pragma checksum "..\..\..\View\ChatPageFuncView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B02CAD87DB0A93BAEEA250CA9F23A4A1B5865BAC1B2F9BFDD2DBCAE81CBB532C"
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
    /// ChatPageFuncView
    /// </summary>
    public partial class ChatPageFuncView : System.Windows.Navigation.PageFunction<string>, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\View\ChatPageFuncView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl Chat;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\View\ChatPageFuncView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer ChatScroll;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\View\ChatPageFuncView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MessageTextBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\View\ChatPageFuncView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MessagePlaceHolder;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\View\ChatPageFuncView.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Falsechat;component/view/chatpagefuncview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ChatPageFuncView.xaml"
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
            
            #line 19 "..\..\..\View\ChatPageFuncView.xaml"
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
            
            #line 51 "..\..\..\View\ChatPageFuncView.xaml"
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

