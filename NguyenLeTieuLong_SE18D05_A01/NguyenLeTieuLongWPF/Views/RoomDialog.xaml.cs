using NguyenLeTieuLongWPF.Models;
using NguyenLeTieuLongWPF.Services;
using System.Windows;

namespace NguyenLeTieuLongWPF.Views
{
    public partial class RoomDialog : Window
    {
        public Room Room { get; private set; }

        public RoomDialog(Room room = null)
        {
            InitializeComponent();
            Room = room ?? new Room
            {
                RoomID = DataService.Instance.RoomRepo.GetAll().Count + 1,
                RoomStatus = 1
            };
            DataContext = Room;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Room.RoomMaxCapacity.ToString(), out int maxCapacity) || maxCapacity < 0)
            {
                MessageBox.Show("Invalid Max Capacity");
                return;
            }
            if (!decimal.TryParse(Room.RoomPricePerDate.ToString(), out decimal pricePerDate) || pricePerDate < 0)
            {
                MessageBox.Show("Invalid Price Per Day");
                return;
            }
            if (!int.TryParse(Room.RoomTypeID.ToString(), out int roomTypeId) || roomTypeId < 0)
            {
                MessageBox.Show("Invalid Room Type ID");
                return;
            }

            Room.RoomMaxCapacity = maxCapacity;
            Room.RoomPricePerDate = pricePerDate;
            Room.RoomTypeID = roomTypeId;

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
