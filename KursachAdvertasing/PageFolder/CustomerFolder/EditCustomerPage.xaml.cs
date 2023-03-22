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
using KursachAdvertasing.DataFolder;
using KursachAdvertasing.ClassFolder;

namespace KursachAdvertasing.PageFolder.CustomerFolder
{
    /// <summary>
    /// Логика взаимодействия для EditCustomerPage.xaml
    /// </summary>
    public partial class EditCustomerPage : Page
    {
        Сustomer customer = new Сustomer();

        public EditCustomerPage()
        {
            InitializeComponent();
            DataContext = customer;

            this.customer.IdCustomer = customer.IdCustomer;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                customer = DBEntities.GetContext().Сustomer
                    .FirstOrDefault(u => u.IdCustomer == customer.IdCustomer); 
                customer.NameCustomer = NameTb.Text;
                customer.SurnameCustomer = LastNameTb.Text;
                customer.Phone = LanguageTb.Text;
                customer.EMailCustomer = CountryTb.Text;
                DBEntities.GetContext().SaveChanges();
                MBClass.InfoMB("Данные успешно отредак тированы ");
                NavigationService.Navigate(new CustomerListPage());
            }
            catch (Exception ex)
            {
                MBClass.ErrorMB(ex);
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomerListPage());
        }
    }
}
