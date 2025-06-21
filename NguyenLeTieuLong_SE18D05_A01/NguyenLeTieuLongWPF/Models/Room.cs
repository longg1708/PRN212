using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenLeTieuLongWPF.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string? RoomNumber { get; set; }
        public string? RoomDescription { get; set; }
        public int RoomMaxCapacity { get; set; }
        public int RoomStatus { get; set; } // 1 = Active, 2 = Deleted, 3 = Booked
        public decimal RoomPricePerDate { get; set; }
        public int RoomTypeID { get; set; }
        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}