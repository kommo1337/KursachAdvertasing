﻿using KursachAdvertasing.ClassFolder;
using KursachAdvertasing.PageFolder.AdvertasingFolder;
using KursachAdvertasing.PageFolder.CustomerFolder;
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
using System.Windows.Shapes;

namespace KursachAdvertasing.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для AdvertasingWindow.xaml
    /// </summary>
    public partial class AdvertasingWindow : Window
    {
        public AdvertasingWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AdvertasingListPage());
        }

        private void CloseIm_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MBClass.ExitMB();
        }

        private void ListBookBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AdvertasingListPage());
        }

        private void AddBookBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddAdvertasingPage());
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MBClass.ExitMB();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
