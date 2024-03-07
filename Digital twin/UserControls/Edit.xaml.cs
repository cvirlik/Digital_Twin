﻿using Digital_twin.Dataset;
using Microsoft.Win32;
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

namespace Digital_twin.UserControls
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : UserControl
    {
        DataManager dataManager;
        public Edit()
        {
            InitializeComponent();
        }
        private void SetEdit(object sender, RoutedEventArgs e)
        {
            if (dataManager == null) dataManager = this.DataContext as DataManager;
            dataManager.State = "Edit";
        }
    }
}
