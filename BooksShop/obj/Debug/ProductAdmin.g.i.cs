﻿#pragma checksum "..\..\ProductAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AEE62C85C7E48A20F07115DC3CFE9438366F728FB7C86F655F3A3CCE9C7D9767"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BooksShop;
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


namespace BooksShop {
    
    
    /// <summary>
    /// ProductAdmin
    /// </summary>
    public partial class ProductAdmin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\ProductAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameProduct;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ProductAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBTypeProduct;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ProductAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBManufProduct;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ProductAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Insert;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ProductAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Update;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ProductAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ProductAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ProductAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView DataGrid;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\ProductAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Exits;
        
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
            System.Uri resourceLocater = new System.Uri("/BooksShop;component/productadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProductAdmin.xaml"
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
            this.NameProduct = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CBTypeProduct = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.CBManufProduct = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.Insert = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\ProductAdmin.xaml"
            this.Insert.Click += new System.Windows.RoutedEventHandler(this.Insert_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Update = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\ProductAdmin.xaml"
            this.Update.Click += new System.Windows.RoutedEventHandler(this.Update_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Delete = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\ProductAdmin.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\ProductAdmin.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DataGrid = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.Exits = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

