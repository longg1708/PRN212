using NguyenLeTieuLongWPF.Models;
using NguyenLeTieuLongWPF.Services;
using System.Windows;
using System.Windows.Controls;

namespace NguyenLeTieuLongWPF.Views
{
    public partial class BookingDialog : Window
    {
        public Booking Booking { get; private set; }
        private readonly DataService _dataService;

        public BookingDialog(Booking booking = null)
        {
            InitializeComponent();
            _dataService = DataService.Instance;

            Booking = booking ?? new Booking
            {
                BookingID = _dataService.BookingRepo.GetAll().Count + 1,
                BookingStatus = 1,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(1)
            };
            if (Booking == null) throw new InvalidOperationException("Booking initialization failed.");
            DataContext = Booking;

            var customers = _dataService.CustomerRepo.GetAll() ?? new List<Customer>();
            var rooms = _dataService.RoomRepo.GetAll() ?? new List<Room>();
            if (!customers.Any() || !rooms.Any())
            {
                MessageBox.Show("No customers or rooms available.");
                return;
            }
            CustomerComboBox.ItemsSource = customers;
            RoomComboBox.ItemsSource = rooms;
            if (booking != null)
            {
                CustomerComboBox.SelectedValue = booking.CustomerID;
                RoomComboBox.SelectedValue = booking.RoomID;
            }
            else
            {
                CustomerComboBox.SelectedIndex = 0;
                RoomComboBox.SelectedIndex = 0;
            }
        }

        private void CustomerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CustomerComboBox.SelectedValue != null)
                Booking.CustomerID = (int)CustomerComboBox.SelectedValue;
        }

        private void RoomComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoomComboBox.SelectedValue != null)
                Booking.RoomID = (int)RoomComboBox.SelectedValue;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Booking.StartDate >= Booking.EndDate)
            {
                MessageBox.Show("End Date must be after Start Date.");
                return;
            }

            var customer = _dataService.CustomerRepo.GetById(Booking.CustomerID);
            var room = _dataService.RoomRepo.GetById(Booking.RoomID);
            if (customer == null || room == null)
            {
                MessageBox.Show("Invalid Customer or Room ID.");
                return;
            }

            Booking.TotalPrice = (Booking.EndDate - Booking.StartDate).Days * room.RoomPricePerDate;
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
