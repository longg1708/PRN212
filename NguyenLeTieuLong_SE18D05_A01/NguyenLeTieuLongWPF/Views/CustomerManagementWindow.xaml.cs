using NguyenLeTieuLongWPF.Models;
using NguyenLeTieuLongWPF.Services;
using NguyenLeTieuLongWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace NguyenLeTieuLongWPF.Views
{
    public partial class CustomerManagementWindow : Window
    {
        public CustomerViewModel ViewModel { get; set; }

        public CustomerManagementWindow()
        {
            InitializeComponent();
            ViewModel = new CustomerViewModel();
            DataContext = ViewModel;
            // Load initial data
            ViewModel.Customers.Clear();
            foreach (var customer in DataService.Instance.CustomerRepo.GetAll())
            {
                ViewModel.Customers.Add(customer);
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CustomerDialog();
            if (dialog.ShowDialog() == true)
            {
                ViewModel.AddCustomer(dialog.Customer);
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            var selectedCustomer = (Customer)((ListBox)FindName("PART_ListBox")).SelectedItem;
            if (selectedCustomer != null)
            {
                var dialog = new CustomerDialog(selectedCustomer);
                if (dialog.ShowDialog() == true)
                {
                    ViewModel.UpdateCustomer(dialog.Customer);
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selectedCustomer = (Customer)((ListBox)FindName("PART_ListBox")).SelectedItem;
            if (selectedCustomer != null && MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ViewModel.DeleteCustomer(selectedCustomer.CustomerID);
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var searchDialog = new SearchDialog();
            if (searchDialog.ShowDialog() == true)
            {
                var searchedCustomers = ViewModel.Customers
                    .Where(c => c.CustomerFullName != null && c.CustomerFullName.Contains(searchDialog.SearchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                ViewModel.Customers.Clear();
                foreach (var customer in searchedCustomers)
                {
                    ViewModel.Customers.Add(customer);
                }
            }
        }

        private void GenerateReport_Click(object sender, RoutedEventArgs e)
        {
            var startDate = DateTime.Now.AddDays(-30);
            var endDate = DateTime.Now;
            var report = ViewModel.Customers
                .SelectMany(c => c.Bookings.Where(b => b.StartDate >= startDate && b.EndDate <= endDate))
                .OrderByDescending(b => b.StartDate)
                .Select(b => $"Booking ID: {b.BookingID}, Customer: {ViewModel.Customers.First(c => c.CustomerID == b.CustomerID).CustomerFullName}, Room: {b.RoomID}, Date: {b.StartDate:d} to {b.EndDate:d}, Total: {b.TotalPrice:C}")
                .ToList();
            MessageBox.Show(string.Join("\n", report.Any() ? report : new[] { "No bookings in the selected period." }), "Customer Report");
        }
    }
}