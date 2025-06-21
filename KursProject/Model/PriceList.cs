using KursProject.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Model
{
   public class PriceList:ViewModelBase
    {
        private int id_price;
        public int Id_Price
        {
            get { return id_price; }
            set { id_price = value; OnPropertyChanged(nameof(Id_Price)); }
        }
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(nameof(Price)); }
        }
    }
}
