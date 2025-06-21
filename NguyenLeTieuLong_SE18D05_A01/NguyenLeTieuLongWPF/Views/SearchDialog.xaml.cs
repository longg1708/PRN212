using System.Windows;

namespace NguyenLeTieuLongWPF.Views
{
    public partial class SearchDialog : Window
    {
        public string SearchText { get; private set; }

        public SearchDialog()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchText = SearchTextBox.Text;
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }
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
