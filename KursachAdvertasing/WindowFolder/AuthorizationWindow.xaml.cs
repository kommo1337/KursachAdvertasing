using KursachAdvertasing.ClassFolder;
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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void CloseIm_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MBClass.ExitMB();
        }

        private void LogInBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = DBEntities.GetContext()
                    .User.FirstOrDefault(u => u.Login == LoginTb.Text);

                if (user == null)
                {
                    MBClass.ErrorMB("Введен не верный логин");
                    LoginTb.Focus();
                    return;
                }
                if (user.Password != PasswordPB.Password)
                {
                    MBClass.ErrorMB("Введен не верный пароль");
                    PasswordPB.Focus();
                    return;
                }
                else
                {
                    switch (user.IdRole)
                    {
                        case 1:
                            new AdvertasingWindow().Show();
                            Close();
                            break;
                        case 2:
                            new CustomerWindow().Show();
                            Close();
                            break;
                        //case 3:
                        //    new ExcursionWindow().Show();
                        //    Close();
                        //    break;
                    }
                }
            }
            catch (Exception ex)
            {
                MBClass.ErrorMB(ex);
            }
        }

        private void RegistrationTB_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new RegistrationWindow().Show();
            Close();
        }
    }
}
