using NguyenLeTieuLongWPF.Models;
using NguyenLeTieuLongWPF.Services;
using NguyenLeTieuLongWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace NguyenLeTieuLongWPF.Views
{
    public partial class RoomManagementWindow : Window
    {
        public RoomViewModel ViewModel { get; set; }

        public RoomManagementWindow()
        {
            InitializeComponent();
            ViewModel = new RoomViewModel();
            DataContext = ViewModel;
            // Load initial data
            ViewModel.Rooms.Clear();
            foreach (var room in DataService.Instance.RoomRepo.GetAll())
            {
                ViewModel.Rooms.Add(room);
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new RoomDialog();
            if (dialog.ShowDialog() == true)
            {
                ViewModel.AddRoom(dialog.Room);
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            var selectedRoom = (Room)((ListBox)FindName("PART_ListBox")).SelectedItem;
            if (selectedRoom != null)
            {
                var dialog = new RoomDialog(selectedRoom);
                if (dialog.ShowDialog() == true)
                {
                    ViewModel.UpdateRoom(dialog.Room);
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selectedRoom = (Room)((ListBox)FindName("PART_ListBox")).SelectedItem;
            if (selectedRoom != null && MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ViewModel.DeleteRoom(selectedRoom.RoomID);
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var searchDialog = new SearchDialog();
            if (searchDialog.ShowDialog() == true)
            {
                var searchedRooms = ViewModel.Rooms
                    .Where(r => r.RoomNumber != null && r.RoomNumber.Contains(searchDialog.SearchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                ViewModel.Rooms.Clear();
                foreach (var room in searchedRooms)
                {
                    ViewModel.Rooms.Add(room);
                }
            }
        }
    }
}