using NguyenLeTieuLongWPF.Models;
using NguyenLeTieuLongWPF.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NguyenLeTieuLongWPF.ViewModels
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Customer> _customers;

        public ObservableCollection<Customer> Customers
        {
            get => _customers;
            set { _customers = value; OnPropertyChanged(); }
        }

        public CustomerViewModel()
        {
            _customers = new ObservableCollection<Customer>(DataService.Instance.CustomerRepo.GetAll());
        }

        public void AddCustomer(Customer customer) => Customers.Add(customer);
        public void UpdateCustomer(Customer customer)
        {
            var index = Customers.IndexOf(Customers.First(c => c.CustomerID == customer.CustomerID));
            if (index >= 0) Customers[index] = customer;
        }
        public void DeleteCustomer(int id) => Customers.Remove(Customers.First(c => c.CustomerID == id));

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}