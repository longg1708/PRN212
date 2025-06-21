using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenLeTieuLongWPF.Repositories;

namespace NguyenLeTieuLongWPF.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int RoomID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int BookingStatus { get; set; } // 1 = Active, 2 = Cancelled
    }
}