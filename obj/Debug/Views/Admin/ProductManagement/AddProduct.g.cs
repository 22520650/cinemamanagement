﻿#pragma checksum "..\..\..\..\..\Views\Admin\ProductManagement\AddProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E28BB16DD6E91B6C991E37768E1E71E877C949567A8B47F16EBBDA87D3B432F1"
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
    /// AddProduct
    /// </summary>
    public partial class AddProduct : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\Views\Admin\ProductManagement\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal cinema_management.Views.Admin.ProductManagement.AddProduct AddFoodWd;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\..\Views\Admin\ProductManagement\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.ColorZone HeaderAddFood;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\..\Views\Admin\ProductManagement\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _Gender;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\..\Views\Admin\ProductManagement\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tboxName;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\..\Views\Admin\ProductManagement\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tboxPrice;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\..\..\..\Views\Admin\ProductManagement\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar prg;
        
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
            System.Uri resourceLocater = new System.Uri("/cinema-management;component/views/admin/productmanagement/addproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Admin\ProductManagement\AddProduct.xaml"
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
            this.AddFoodWd = ((cinema_management.Views.Admin.ProductManagement.AddProduct)(target));
            
            #line 25 "..\..\..\..\..\Views\Admin\ProductManagement\AddProduct.xaml"
            this.AddFoodWd.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.AddFoodWd_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.HeaderAddFood = ((MaterialDesignThemes.Wpf.ColorZone)(target));
            return;
            case 3:
            this._Gender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.tboxName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.tboxPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 135 "..\..\..\..\..\Views\Admin\ProductManagement\AddProduct.xaml"
            this.tboxPrice.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 136 "..\..\..\..\..\Views\Admin\ProductManagement\AddProduct.xaml"
            this.tboxPrice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.prg = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

