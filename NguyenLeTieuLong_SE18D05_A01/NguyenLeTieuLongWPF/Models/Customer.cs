using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenLeTieuLongWPF.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? CustomerFullName { get; set; }
        public string? Telephone { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime CustomerBirthday { get; set; }
        public int CustomerStatus { get; set; } // 1 = Active, 2 = Deleted
        public string? Password { get; set; }
        public ObservableCollection<Booking> Bookings { get; set; } = new ObservableCollection<Booking>();
    }
}