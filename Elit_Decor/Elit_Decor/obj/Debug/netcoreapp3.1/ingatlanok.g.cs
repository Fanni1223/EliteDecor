﻿#pragma checksum "..\..\..\ingatlanok.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F390B762F36691A52C29A33C2DDD65A3ACF9F9A7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Elit_Decor;
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


namespace Elit_Decor {
    
    
    /// <summary>
    /// ingatlanok
    /// </summary>
    public partial class ingatlanok : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\ingatlanok.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Szolgaltatasok_menu;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\ingatlanok.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Idopontfoglalas_menu;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\ingatlanok.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Kereses_menu;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\ingatlanok.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid adatok;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\ingatlanok.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nev;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\ingatlanok.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button felvezetes;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\ingatlanok.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox kereses;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\ingatlanok.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button gomb1;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\ingatlanok.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Elit_Decor;component/ingatlanok.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ingatlanok.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Szolgaltatasok_menu = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 2:
            this.Idopontfoglalas_menu = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            this.Kereses_menu = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 4:
            this.adatok = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\..\ingatlanok.xaml"
            this.adatok.Loaded += new System.Windows.RoutedEventHandler(this.adatok_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.nev = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.felvezetes = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\ingatlanok.xaml"
            this.felvezetes.Click += new System.Windows.RoutedEventHandler(this.felvezetes_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.kereses = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.gomb1 = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.email = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

