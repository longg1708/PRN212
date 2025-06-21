using NguyenLeTieuLongWPF.Models;
using NguyenLeTieuLongWPF.Services;
using System.Windows;
using System.Windows.Controls;

namespace NguyenLeTieuLongWPF.Views
{
    public partial class CustomerDialog : Window
    {
        public Customer Customer { get; private set; }

        public CustomerDialog(Customer customer = null)
        {
            InitializeComponent();
            Customer = customer ?? new Customer
            {
                CustomerID = DataService.Instance.CustomerRepo.GetAll().Count + 1,
                CustomerStatus = 1
            };
            DataContext = Customer;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Customer.Password = (PasswordBox as PasswordBox)?.Password;
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}