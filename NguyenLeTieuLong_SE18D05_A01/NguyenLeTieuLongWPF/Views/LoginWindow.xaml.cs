using NguyenLeTieuLongWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NguyenLeTieuLongWPF.Views
{
    public partial class LoginWindow : Window
    {
        public LoginViewModel ViewModel { get; set; }

        public LoginWindow()
        {
            InitializeComponent();
            ViewModel = new LoginViewModel();
            DataContext = ViewModel;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Password = PasswordBox.Password;
            ViewModel.Login();
        }
    }
}