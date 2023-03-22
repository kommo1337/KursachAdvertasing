﻿using KursachAdvertasing.ClassFolder;
using KursachAdvertasing.DataFolder;
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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseIm_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MBClass.ExitMB();
        }

        private void RegistrationBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBEntities.GetContext().User.Add(new User()
                {
                    Login = LoginTb.Text,
                    Password = PasswordPB.Password,
                    IdRole = 2
                });
                DBEntities.GetContext().SaveChanges();

                MBClass.InfoMB("Вы успешно зарегистрировались");
                new AuthorizationWindow().Show();
                Close();
            }
            catch (Exception ex)
            {
                MBClass.ErrorMB(ex);
            }
        }

        private void BackTB_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            new AuthorizationWindow().Show();
            Close();
        }
    }
}
