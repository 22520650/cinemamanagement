﻿#pragma checksum "..\..\..\..\..\Views\Admin\ProductManagement\ImportProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "688E43F6DB870E14FF23F33733B1C3A510E89615745EA7002B941AD7A3C38EA5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
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
using cinema_management.Views.Admin.ProductManagement;


namespace cinema_management.Views.Admin.ProductManagement {
    
    
    /// <summary>
    /// ImportProduct
    /// </summary>
    public partial class ImportProduct : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\Views\Admin\ProductManagement\ImportProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal cinema_management.Views.Admin.ProductManagement.ImportProduct ImportFoodWd;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\..\Views\Admin\ProductManagement\ImportProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _Gender;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\..\..\Views\Admin\ProductManagement\ImportProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tboxName;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\..\..\Views\Admin\ProductManagement\ImportProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImportImage;
        
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
            System.Uri resourceLocater = new System.Uri("/cinema-management;component/views/admin/productmanagement/importproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Admin\ProductManagement\ImportProduct.xaml"
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
            this.ImportFoodWd = ((cinema_management.Views.Admin.ProductManagement.ImportProduct)(target));
            
            #line 22 "..\..\..\..\..\Views\Admin\ProductManagement\ImportProduct.xaml"
            this.ImportFoodWd.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImportFoodWd_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this._Gender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            
            #line 135 "..\..\..\..\..\Views\Admin\ProductManagement\ImportProduct.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this._price_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 136 "..\..\..\..\..\Views\Admin\ProductManagement\ImportProduct.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tboxName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 147 "..\..\..\..\..\Views\Admin\ProductManagement\ImportProduct.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this._price_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 148 "..\..\..\..\..\Views\Admin\ProductManagement\ImportProduct.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ImportImage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

