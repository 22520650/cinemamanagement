﻿#pragma checksum "..\..\..\..\..\Views\Staff\MovieScheduleWindow\MovieScheduleWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9D28ED594D2B668EEE06B74C97B0C869E387E1D13D47164C124E7A1653D5E0ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using cinema_management.Views.Staff.MovieScheduleWindow;


namespace cinema_management.Views.Staff.MovieScheduleWindow {
    
    
    /// <summary>
    /// MovieScheduleWindow
    /// </summary>
    public partial class MovieScheduleWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 9 "..\..\..\..\..\Views\Staff\MovieScheduleWindow\MovieScheduleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal cinema_management.Views.Staff.MovieScheduleWindow.MovieScheduleWindow Movie_Schedule;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\..\Views\Staff\MovieScheduleWindow\MovieScheduleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _ShowDate;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\..\Views\Staff\MovieScheduleWindow\MovieScheduleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgframe;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\..\Views\Staff\MovieScheduleWindow\MovieScheduleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtframe;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\..\Views\Staff\MovieScheduleWindow\MovieScheduleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox _ShowTimeList;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\..\..\Views\Staff\MovieScheduleWindow\MovieScheduleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _Room;
        
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
            System.Uri resourceLocater = new System.Uri("/cinema-management;component/views/staff/movieschedulewindow/movieschedulewindow." +
                    "xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Staff\MovieScheduleWindow\MovieScheduleWindow.xaml"
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
            this.Movie_Schedule = ((cinema_management.Views.Staff.MovieScheduleWindow.MovieScheduleWindow)(target));
            
            #line 20 "..\..\..\..\..\Views\Staff\MovieScheduleWindow\MovieScheduleWindow.xaml"
            this.Movie_Schedule.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Movie_Schedule_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 53 "..\..\..\..\..\Views\Staff\MovieScheduleWindow\MovieScheduleWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this._ShowDate = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.imgframe = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.txtframe = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            
            #line 126 "..\..\..\..\..\Views\Staff\MovieScheduleWindow\MovieScheduleWindow.xaml"
            ((System.Windows.Controls.Expander)(target)).Collapsed += new System.Windows.RoutedEventHandler(this.Expander_Collapsed);
            
            #line default
            #line hidden
            return;
            case 7:
            this._ShowTimeList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this._Room = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 8:
            
            #line 153 "..\..\..\..\..\Views\Staff\MovieScheduleWindow\MovieScheduleWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonUp);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

