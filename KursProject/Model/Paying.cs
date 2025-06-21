using KursProject.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Model
{
    public class Paying:ViewModelBase
    {
        private int id_Paying;
        public int Id_Paying
        {
            get { return id_Paying; }
            set { id_Paying = value; OnPropertyChanged(nameof(Id_Paying)); }
        }
        private int id_Renting;
        public int Id_Renting
        {
            get { return id_Renting; }
            set { id_Renting = value; OnPropertyChanged(nameof(Id_Renting)); }
        }
        private DateTime date_Payment;
        public DateTime Date_Payment
        {
            get { return date_Payment; }
            set { date_Payment = value; OnPropertyChanged(nameof(Date_Payment)); }
        }
        private string type_Pay;
        public string Type_Pay
        {
            get => type_Pay;
            set { type_Pay = value; OnPropertyChanged(nameof(Type_Pay)); }
        }
        private decimal payment;
        public decimal Payment
        {
            get=> payment;
            set { payment= value ; OnPropertyChanged(nameof(Payment));}
        }



    }
}
