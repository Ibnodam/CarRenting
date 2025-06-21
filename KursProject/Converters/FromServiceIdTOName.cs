using KursProject.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace KursProject.Converters
{
    public class FromServiceIdTOName : IValueConverter
    {
        public List<Servic> Services { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is int serviceId) || serviceId == 0 || Services == null)
                return string.Empty;

            var service = Services.FirstOrDefault(s => s.Id_Service == serviceId);
            return service?.Name_Service ?? $"Услуга {serviceId}";
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
