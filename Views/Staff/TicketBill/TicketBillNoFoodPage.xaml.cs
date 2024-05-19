﻿using cinema_management.ViewModel.StaffVM.TicketBillVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cinema_management.Views.Staff.TicketBill
{
    /// <summary>
    /// Interaction logic for TicketBillNoFoodPage.xaml
    /// </summary>
    public partial class TicketBillNoFoodPage : Page
    {
        public TicketBillNoFoodPage()
        {
            InitializeComponent();
            DataContext = new TicketBillViewModel();
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }
    }
}
