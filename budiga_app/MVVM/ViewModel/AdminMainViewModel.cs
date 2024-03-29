﻿using budiga_app.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budiga_app.MVVM.ViewModel
{
    public class AdminMainViewModel : ObservableObject
    {
        
        public RelayCommand InventoryViewCommand { get; set; }        
        public RelayCommand InvoiceViewCommand { get; set; }
        public RelayCommand SalesViewCommand { get; set; }
        public RelayCommand EmployeeViewCommand { get; set; }
        public InventoryViewModel InventoryVM { get; set; }
        public InvoiceViewModel InvoiceVM { get; set; }
        public SalesViewModel SalesVM { get; set; }     
        public EmployeeViewModel EmployeeVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public AdminMainViewModel()
        {
            try
            {
                InventoryVM = new InventoryViewModel();
                InvoiceVM = new InvoiceViewModel();
                SalesVM = new SalesViewModel();                                
                EmployeeVM = new EmployeeViewModel();

                CurrentView = InventoryVM;

                InventoryViewCommand = new RelayCommand(o =>
                {
                    CurrentView = InventoryVM;
                });

                SalesViewCommand = new RelayCommand(o =>
                {
                    CurrentView = SalesVM;
                });

                InvoiceViewCommand = new RelayCommand(o =>
                {
                    CurrentView = InvoiceVM;
                });

                EmployeeViewCommand = new RelayCommand(o =>
                {
                    CurrentView = EmployeeVM;
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }

        }
    }
}
