﻿#pragma checksum "..\..\..\..\..\Views\Admin\Import_ExportManagement\TicketDetail.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D2374AA37A2845D8A28B8EBA92027346CFF79CF9443B8D64F12382B988FFB9E5"
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
using cinema_management.Views.Admin.Import_ExportManagement;


namespace cinema_management.Views.Admin.Import_ExportManagement {
    
    
    /// <summary>
    /// TicketDetail
    /// </summary>
    public partial class TicketDetail : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\Views\Admin\Import_ExportManagement\TicketDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal cinema_management.Views.Admin.Import_ExportManagement.TicketDetail mainWin;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\..\Views\Admin\Import_ExportManagement\TicketDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label _moviename;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\..\..\..\Views\Admin\Import_ExportManagement\TicketDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label _price;
        
        #line default
        #line hidden
        
        
        #line 260 "..\..\..\..\..\Views\Admin\Import_ExportManagement\TicketDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label _time;
        
        #line default
        #line hidden
        
        
        #line 280 "..\..\..\..\..\Views\Admin\Import_ExportManagement\TicketDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label _totalticket;
        
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
            System.Uri resourceLocater = new System.Uri("/cinema-management;component/views/admin/import_exportmanagement/ticketdetail.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Admin\Import_ExportManagement\TicketDetail.xaml"
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
            this.mainWin = ((cinema_management.Views.Admin.Import_ExportManagement.TicketDetail)(target));
            
            #line 17 "..\..\..\..\..\Views\Admin\Import_ExportManagement\TicketDetail.xaml"
            this.mainWin.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 64 "..\..\..\..\..\Views\Admin\Import_ExportManagement\TicketDetail.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Button_MouseEnter_1);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\..\..\Views\Admin\Import_ExportManagement\TicketDetail.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Button_MouseLeave_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this._moviename = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this._price = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this._time = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this._totalticket = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

