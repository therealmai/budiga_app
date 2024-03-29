﻿using budiga_app.MVVM.Model;
using budiga_app.MVVM.ViewModel;
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

namespace budiga_app.MVVM.View
{
    /// <summary>
    /// Interaction logic for SalesInventoryView.xaml
    /// </summary>
    public partial class SalesInventoryView : UserControl
    {
        public SalesViewModel ViewModel { get; set; }
        
        
        public SalesInventoryView()
        {
            ViewModel = SalesViewModel.GetInstance;
            InitializeComponent();
            
        }
    }
}
