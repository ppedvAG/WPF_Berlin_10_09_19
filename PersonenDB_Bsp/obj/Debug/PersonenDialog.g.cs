﻿#pragma checksum "..\..\PersonenDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "005EAEC3593F693D8E20B79DB424CDE33798E23BD9A68DB42A8CC7B136051EBA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PersonenDB_Bsp;
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


namespace PersonenDB_Bsp {
    
    
    /// <summary>
    /// PersonenDialog
    /// </summary>
    public partial class PersonenDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 64 "..\..\PersonenDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxVorname;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\PersonenDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxNachname;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\PersonenDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dprGeburtsdatum;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\PersonenDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chbVerheiratet;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\PersonenDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbLieblingsfarbe;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\PersonenDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\PersonenDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAbbruch;
        
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
            System.Uri resourceLocater = new System.Uri("/PersonenDB_Bsp;component/personendialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PersonenDialog.xaml"
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
            this.tbxVorname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbxNachname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.dprGeburtsdatum = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.chbVerheiratet = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.cbbLieblingsfarbe = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\PersonenDialog.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.BtnOk_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAbbruch = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\PersonenDialog.xaml"
            this.btnAbbruch.Click += new System.Windows.RoutedEventHandler(this.BtnAbbruch_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

