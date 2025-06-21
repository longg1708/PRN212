using System.Globalization;
using System.Windows.Data;
using NguyenLeTieuLongWPF.Services;

namespace NguyenLeTieuLongWPF.Converters
{
    public class CustomerNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int customerId && parameter?.ToString() == "CustomerFullName")
            {
                var customer = DataService.Instance.CustomerRepo.GetById(customerId);
                return customer?.CustomerFullName ?? "Unknown Customer";
            }
            return value?.ToString() ?? "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
