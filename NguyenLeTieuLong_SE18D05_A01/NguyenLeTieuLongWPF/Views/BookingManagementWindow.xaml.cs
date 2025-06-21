using NguyenLeTieuLongWPF.Models;
using NguyenLeTieuLongWPF.Services;
using NguyenLeTieuLongWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace NguyenLeTieuLongWPF.Views
{
    public partial class BookingManagementWindow : Window
    {
        public BookingViewModel ViewModel { get; set; }

        public BookingManagementWindow()
        {
            InitializeComponent();
            ViewModel = new BookingViewModel();
            DataContext = ViewModel;
            try
            {
                ViewModel.LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}");
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new BookingDialog();
            if (dialog.ShowDialog() == true)
            {
                ViewModel.AddBooking(dialog.Booking);
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            var selectedBooking = (Booking)((ListBox)FindName("PART_ListBox")).SelectedItem;
            if (selectedBooking != null)
            {
                var dialog = new BookingDialog(selectedBooking);
                if (dialog.ShowDialog() == true)
                {
                    ViewModel.UpdateBooking(dialog.Booking);
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selectedBooking = (Booking)((ListBox)FindName("PART_ListBox")).SelectedItem;
            if (selectedBooking != null && MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ViewModel.DeleteBooking(selectedBooking.BookingID);
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var searchDialog = new SearchDialog();
            if (searchDialog.ShowDialog() == true)
            {
                var searchedBookings = ViewModel.Bookings
                    .Where(b => b.BookingID.ToString().Contains(searchDialog.SearchText) ||
                               DataService.Instance.CustomerRepo.GetById(b.CustomerID)?.CustomerFullName?.Contains(searchDialog.SearchText) == true ||
                               DataService.Instance.RoomRepo.GetById(b.RoomID)?.RoomNumber?.Contains(searchDialog.SearchText) == true)
                    .ToList();
                ViewModel.Bookings.Clear();
                foreach (var booking in searchedBookings)
                {
                    ViewModel.Bookings.Add(booking);
                }
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ViewModel.LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing bookings: {ex.Message}");
            }
        }
    }
}
