using NguyenLeTieuLongWPF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenLeTieuLongWPF.Services
{
    public class DataService
    {
        private static DataService _instance;
        public static DataService Instance => _instance ??= new DataService();

        public CustomerRepository CustomerRepo { get; } = new CustomerRepository();
        public RoomRepository RoomRepo { get; } = new RoomRepository();
        public BookingRepository BookingRepo { get; } = new BookingRepository();
    }
}