﻿#pragma checksum "..\..\MD5Hasher.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AE83D2E379BC3E594EC484E4EB20C22C1121823AD653F085DB2809D5C6EE224E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BH2ShipHashEditor;
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


namespace BH2ShipHashEditor {
    
    
    /// <summary>
    /// MD5Hasher
    /// </summary>
    public partial class MD5Hasher : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\MD5Hasher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BH2ShipHashEditor.MD5Hasher MD5HasherWin;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MD5Hasher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ToHash;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MD5Hasher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ResultingHash;
        
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
            System.Uri resourceLocater = new System.Uri("/BH2ShipHashEditor;component/md5hasher.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MD5Hasher.xaml"
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
            this.MD5HasherWin = ((BH2ShipHashEditor.MD5Hasher)(target));
            return;
            case 2:
            this.ToHash = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\MD5Hasher.xaml"
            this.ToHash.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ToHash_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ResultingHash = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\MD5Hasher.xaml"
            this.ResultingHash.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ResultingHash_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 15 "..\..\MD5Hasher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 16 "..\..\MD5Hasher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

