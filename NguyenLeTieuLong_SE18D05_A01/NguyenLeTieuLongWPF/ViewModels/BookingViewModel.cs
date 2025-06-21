using NguyenLeTieuLongWPF.Models;
using NguyenLeTieuLongWPF.Repositories;
using NguyenLeTieuLongWPF.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Collections.ObjectModel;

namespace NguyenLeTieuLongWPF.ViewModels
{
    public class BookingViewModel : INotifyPropertyChanged
    {
        private int _customerId;
        private int _roomId;
        private DateTime _startDate = DateTime.Now;
        private DateTime _endDate = DateTime.Now.AddDays(1);
        private string _availabilityMessage = string.Empty;
        private ObservableCollection<Booking> _bookings;

        public int CustomerId
        {
            get => _customerId;
            set { _customerId = value; OnPropertyChanged(); CheckAvailability(); }
        }

        public int RoomId
        {
            get => _roomId;
            set { _roomId = value; OnPropertyChanged(); CheckAvailability(); }
        }

        public DateTime StartDate
        {
            get => _startDate;
            set { _startDate = value; OnPropertyChanged(); CheckAvailability(); }
        }

        public DateTime EndDate
        {
            get => _endDate;
            set { _endDate = value; OnPropertyChanged(); CheckAvailability(); }
        }

        public string AvailabilityMessage
        {
            get => _availabilityMessage;
            set { _availabilityMessage = value; OnPropertyChanged(); }
        }

        public ObservableCollection<Booking> Bookings
        {
            get => _bookings;
            set { _bookings = value; OnPropertyChanged(); }
        }

        public BookingViewModel()
        {
            _bookings = new ObservableCollection<Booking>(DataService.Instance.BookingRepo.GetAll());
        }

        public void LoadBookings()
        {
            var bookings = DataService.Instance.BookingRepo.GetAll() ?? new List<Booking>();
            Bookings.Clear();
            foreach (var booking in bookings)
            {
                Bookings.Add(booking);
            }
        }

        public void AddBooking(Booking booking)
        {
            var bookingRepo = new BookingRepository();
            var customer = DataService.Instance.CustomerRepo.GetById(booking.CustomerID);
            var room = DataService.Instance.RoomRepo.GetById(booking.RoomID);
            if (customer != null && room != null && bookingRepo.IsRoomAvailable(booking.RoomID, booking.StartDate, booking.EndDate))
            {
                booking.TotalPrice = (booking.EndDate - booking.StartDate).Days * room.RoomPricePerDate;
                bookingRepo.AddBooking(booking, customer, room);
                customer.Bookings.Add(booking); // Đảm bảo customer có Bookings
                Bookings.Add(booking);
                MessageBox.Show("Booking added successfully!");
            }
            else
            {
                MessageBox.Show("Invalid booking data or room not available.");
            }
        }

        public void UpdateBooking(Booking booking)
        {
            var bookingRepo = new BookingRepository();
            var existingBooking = Bookings.FirstOrDefault(b => b.BookingID == booking.BookingID);
            if (existingBooking != null)
            {
                var customer = DataService.Instance.CustomerRepo.GetById(booking.CustomerID);
                var room = DataService.Instance.RoomRepo.GetById(booking.RoomID);
                if (customer != null && room != null && bookingRepo.IsRoomAvailable(booking.RoomID, booking.StartDate, booking.EndDate, booking.BookingID))
                {
                    booking.TotalPrice = (booking.EndDate - booking.StartDate).Days * room.RoomPricePerDate;
                    var index = Bookings.IndexOf(existingBooking);
                    Bookings[index] = booking;
                    var repoList = DataService.Instance.BookingRepo.GetAll();
                    if (repoList != null && index < repoList.Count)
                    {
                        repoList[index] = booking;
                    }
                    MessageBox.Show("Booking updated successfully!");
                }
                else
                {
                    MessageBox.Show("Invalid update or room not available.");
                }
            }
        }

        public void DeleteBooking(int bookingId)
        {
            var booking = Bookings.FirstOrDefault(b => b.BookingID == bookingId);
            if (booking != null)
            {
                Bookings.Remove(booking);
                DataService.Instance.BookingRepo.GetAll().Remove(booking); // Cập nhật repository
                MessageBox.Show("Booking deleted successfully!");
            }
        }

        public void CheckAvailability()
        {
            var bookingRepo = new BookingRepository();
            AvailabilityMessage = bookingRepo.IsRoomAvailable(RoomId, StartDate, EndDate) ? "Room is available" : "Room is not available";
        }

        public void MakeBooking()
        {
            var dataService = DataService.Instance;
            var customer = dataService.CustomerRepo.GetById(CustomerId);
            var room = dataService.RoomRepo.GetById(RoomId);

            if (customer == null || room == null)
            {
                MessageBox.Show("Invalid Customer or Room ID");
                return;
            }

            if (StartDate >= EndDate)
            {
                MessageBox.Show("End Date must be after Start Date");
                return;
            }

            var bookingRepo = new BookingRepository();
            var booking = new Booking
            {
                BookingID = dataService.BookingRepo.GetAll().Count + 1,
                CustomerID = CustomerId,
                RoomID = RoomId,
                StartDate = StartDate,
                EndDate = EndDate,
                TotalPrice = (EndDate - StartDate).Days * room.RoomPricePerDate,
                BookingStatus = 1
            };

            try
            {
                bookingRepo.AddBooking(booking, customer, room);
                MessageBox.Show($"Booking Confirmed!\nCustomer: {customer.CustomerFullName}\nRoom: {room.RoomNumber}\nDates: {StartDate:d} to {EndDate:d}\nTotal: {booking.TotalPrice:C}");
                customer.Bookings.Add(booking);
                LoadBookings(); // Cập nhật danh sách
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
