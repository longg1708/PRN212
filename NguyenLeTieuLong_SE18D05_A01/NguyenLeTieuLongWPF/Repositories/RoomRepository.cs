using NguyenLeTieuLongWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenLeTieuLongWPF.Repositories
{
    public class RoomRepository
    {
        private static List<Room> _rooms = new List<Room>
        {
            new Room { RoomID = 1, RoomNumber = "101", RoomDescription = "Standard Room", RoomMaxCapacity = 2, RoomPricePerDate = 100m, RoomTypeID = 1, RoomStatus = 1 },
            new Room { RoomID = 2, RoomNumber = "102", RoomDescription = "Deluxe Room", RoomMaxCapacity = 4, RoomPricePerDate = 200m, RoomTypeID = 2, RoomStatus = 1 },
            new Room { RoomID = 3, RoomNumber = "103", RoomDescription = "Suite Room", RoomMaxCapacity = 6, RoomPricePerDate = 300m, RoomTypeID = 3, RoomStatus = 1 }
        };

        public List<Room> GetAll() => _rooms;
        public Room GetById(int id) => _rooms.FirstOrDefault(r => r.RoomID == id);
        public void Add(Room room) => _rooms.Add(room);
        public void Update(Room room) => _rooms[_rooms.FindIndex(r => r.RoomID == room.RoomID)] = room;
        public void Delete(int id) => _rooms.RemoveAll(r => r.RoomID == id);

        public void UpdateAvailability(int roomId, DateTime startDate, DateTime endDate, bool isBooked)
        {
            var room = GetById(roomId);
            if (room != null)
            {
                if (isBooked && room.RoomStatus == 1)
                    room.RoomStatus = 3; // 3 = Booked
                else if (!isBooked && room.Bookings.All(b => b.EndDate < DateTime.Now))
                    room.RoomStatus = 1; // Revert to Active if no active bookings
            }
        }
    }
}