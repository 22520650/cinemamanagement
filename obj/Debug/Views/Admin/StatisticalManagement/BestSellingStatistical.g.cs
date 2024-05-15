﻿#pragma checksum "..\..\..\..\..\Views\Admin\StatisticalManagement\BestSellingStatistical.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2C90167FECE8BD3C20000BBD1237101F9F586E62AFE4E2710EFE696591B9341A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
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
using cinema_management.ViewModel.AdminVM.StatisticalManagementVM;


namespace cinema_management.Views.Admin.StatisticManagement {
    
    
    /// <summary>
    /// BestSellingStatistical
    /// </summary>
    public partial class BestSellingStatistical : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\Views\Admin\StatisticalManagement\BestSellingStatistical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal cinema_management.Views.Admin.StatisticManagement.BestSellingStatistical mainPage;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\Views\Admin\StatisticalManagement\BestSellingStatistical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox periodbox1;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\..\Views\Admin\StatisticalManagement\BestSellingStatistical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Time1;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\..\..\..\Views\Admin\StatisticalManagement\BestSellingStatistical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox periodbox2;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\..\..\..\Views\Admin\StatisticalManagement\BestSellingStatistical.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Time2;
        
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
            System.Uri resourceLocater = new System.Uri("/cinema-management;component/views/admin/statisticalmanagement/bestsellingstatist" +
                    "ical.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Admin\StatisticalManagement\BestSellingStatistical.xaml"
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
            this.mainPage = ((cinema_management.Views.Admin.StatisticManagement.BestSellingStatistical)(target));
            return;
            case 2:
            this.periodbox1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 61 "..\..\..\..\..\Views\Admin\StatisticalManagement\BestSellingStatistical.xaml"
            this.periodbox1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.periodbox1_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 62 "..\..\..\..\..\Views\Admin\StatisticalManagement\BestSellingStatistical.xaml"
            this.periodbox1.Loaded += new System.Windows.RoutedEventHandler(this.periodbox1_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Time1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.periodbox2 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 210 "..\..\..\..\..\Views\Admin\StatisticalManagement\BestSellingStatistical.xaml"
            this.periodbox2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.periodbox2_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 211 "..\..\..\..\..\Views\Admin\StatisticalManagement\BestSellingStatistical.xaml"
            this.periodbox2.Loaded += new System.Windows.RoutedEventHandler(this.periodbox2_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Time2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

