using NguyenLeTieuLongWPF.Models;
using NguyenLeTieuLongWPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NguyenLeTieuLongWPF.ViewModels
{
    public class RoomViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Room> _rooms;
        public ObservableCollection<Room> Rooms
        {
            get => _rooms;
            set { _rooms = value; OnPropertyChanged(); }
        }

        public RoomViewModel()
        {
            Rooms = new ObservableCollection<Room>(DataService.Instance.RoomRepo.GetAll());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public void AddRoom(Room room)
        {
            DataService.Instance.RoomRepo.Add(room);
            Rooms.Add(room);
        }

        public void UpdateRoom(Room room)
        {
            DataService.Instance.RoomRepo.Update(room);
            var index = Rooms.IndexOf(Rooms.First(r => r.RoomID == room.RoomID));
            Rooms[index] = room;
        }

        public void DeleteRoom(int id)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                DataService.Instance.RoomRepo.Delete(id);
                Rooms.Remove(Rooms.First(r => r.RoomID == id));
            }
        }
    }
}