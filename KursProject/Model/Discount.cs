using KursProject.Services;
using KursProject.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Model
{
    public class Discount:ViewModelBase
    {
        private int id_Discount;
        public int Id_Discount
        {
            get { return id_Discount; }
            set { id_Discount = value; OnPropertyChanged(nameof(Id_Discount)); }
        }
        private decimal present;
        public decimal Present
        {
            get { return present; }
            set { present = value; OnPropertyChanged(nameof(Present)); }
        }
    }
}
