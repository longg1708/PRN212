using NguyenLeTieuLongWPF.Services;
using NguyenLeTieuLongWPF.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace NguyenLeTieuLongWPF.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _email;
        private string _password;

        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(); }
        }

        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public void Login()
        {
            var dataService = DataService.Instance;
            var customer = dataService.CustomerRepo.GetAll().FirstOrDefault(c => c.EmailAddress == Email && c.Password == Password);

            if (customer != null || (Email == "admin@FUMiniHotelSystem.com" && Password == "@@abc123@@"))
            {
                if (Email == "admin@FUMiniHotelSystem.com")
                {
                    new CustomerManagementWindow().Show();
                    new RoomManagementWindow().Show();
                    new BookingManagementWindow().Show();
                }
                else
                {
                    var bookingWindow = new BookingWindow(customer);
                    bookingWindow.Show();
                }
                Application.Current.Windows[0]?.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}