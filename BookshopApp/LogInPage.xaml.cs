﻿using BookshopApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace BookshopApp
{
    /// <summary>
    /// Interaction logic for LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Window
    {
        LogInPageViewModel logInPageVM;
        public LogInPage()
        {
            InitializeComponent();
            logInPageVM = new();
        }

        private void logInBt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
