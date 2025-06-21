using NguyenLeTieuLongWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenLeTieuLongWPF.Repositories
{
    public class BookingRepository
    {
        private static List<Booking> _bookings = new List<Booking>
        {
            new Booking { BookingID = 1, CustomerID = 1, RoomID = 1, StartDate = new DateTime(2025, 6, 20), EndDate = new DateTime(2025, 6, 22), TotalPrice = 200m, BookingStatus = 1 },
            new Booking { BookingID = 2, CustomerID = 2, RoomID = 2, StartDate = new DateTime(2025, 6, 21), EndDate = new DateTime(2025, 6, 23), TotalPrice = 400m, BookingStatus = 1 }
        };
        private readonly RoomRepository _roomRepo;

        public BookingRepository()
        {
            _roomRepo = new RoomRepository();
        }

        public bool IsRoomAvailable(int roomId, DateTime startDate, DateTime endDate, int? bookingId = null)
        {
            var room = _roomRepo.GetById(roomId);
            if (room == null || room.RoomStatus == 2) return false; // Deleted or null room
            return !_bookings.Any(b =>
                b.RoomID == roomId &&
                !(endDate <= b.StartDate || startDate >= b.EndDate) &&
                b.BookingStatus == 1 &&
                (bookingId == null || b.BookingID != bookingId));
        }

        public void AddBooking(Booking booking, Customer customer, Room room)
        {
            if (IsRoomAvailable(booking.RoomID, booking.StartDate, booking.EndDate))
            {
                _bookings.Add(booking);
                customer.Bookings.Add(booking);
                room.Bookings.Add(booking);
                _roomRepo.UpdateAvailability(booking.RoomID, booking.StartDate, booking.EndDate, true);
            }
            else
            {
                throw new Exception("Room not available for the selected dates.");
            }
        }

        public List<Booking> GetAll() => _bookings;
    }
}
