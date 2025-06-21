using System.Globalization;
using System.Windows.Data;
using NguyenLeTieuLongWPF.Services;

namespace NguyenLeTieuLongWPF.Converters
{
    public class RoomNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int roomId && parameter?.ToString() == "RoomNumber")
            {
                var room = DataService.Instance.RoomRepo.GetById(roomId);
                return room?.RoomNumber ?? "Unknown Room";
            }
            return value?.ToString() ?? "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}