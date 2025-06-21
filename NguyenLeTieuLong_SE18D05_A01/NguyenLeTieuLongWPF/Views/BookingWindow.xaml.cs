using NguyenLeTieuLongWPF.Models;
using NguyenLeTieuLongWPF.Services;
using NguyenLeTieuLongWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace NguyenLeTieuLongWPF.Views
{
    public partial class BookingWindow : Window
    {
        public BookingViewModel ViewModel { get; set; }
        public Customer Customer { get; set; }

        public BookingWindow(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            ViewModel = new BookingViewModel { CustomerId = customer.CustomerID };
            DataContext = ViewModel;

            // Populate RoomComboBox
            var rooms = DataService.Instance.RoomRepo.GetAll();
            RoomComboBox.ItemsSource = rooms;
            if (rooms.Any()) RoomComboBox.SelectedIndex = 0;
        }

        private void RoomComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoomComboBox.SelectedItem is Room room)
            {
                ViewModel.RoomId = room.RoomID;
                ViewModel.CheckAvailability();
            }
        }

        private void Book_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.MakeBooking();
        }

        private void SaveProfile_Click(object sender, RoutedEventArgs e)
        {
            var updatedCustomer = DataService.Instance.CustomerRepo.GetById(Customer.CustomerID);
            if (updatedCustomer != null)
            {
                updatedCustomer.CustomerFullName = Customer.CustomerFullName;
                updatedCustomer.Telephone = Customer.Telephone;
                updatedCustomer.EmailAddress = Customer.EmailAddress;
                DataService.Instance.CustomerRepo.Update(updatedCustomer);
                MessageBox.Show("Profile updated successfully!");
            }
            else
            {
                MessageBox.Show("Error updating profile.");
            }
        }
    }
}