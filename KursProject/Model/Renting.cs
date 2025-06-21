using KursProject.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Model
{
    public class Renting : ViewModelBase
    {
        private int id_Renting;
        public int Id_Renting
        {
            get { return id_Renting; }
            set { id_Renting = value; OnPropertyChanged(nameof(Id_Renting)); }
        }
        private DateTime data_Rent= DateTime.Now;
        public DateTime Data_Rent
        {
            get => data_Rent;
            set { data_Rent = value; OnPropertyChanged(nameof(Data_Rent)); }
        }
        private DateTime data_Return= DateTime.Now;
        public DateTime Data_Return
        {
            get => data_Return;
            set { data_Return = value; OnPropertyChanged(nameof(Data_Return)); }
        }
        private bool booking;
        public bool Booking
        {
            get { return booking; }
            set { booking = value; OnPropertyChanged(nameof(Booking)); }
        }
        private int id_Car;
        public int Id_Car
        {
            get => id_Car;
            set { id_Car = value; OnPropertyChanged(nameof(Id_Car)); }
        }
        private int id_Client;
        public int Id_Client
        {
            get => id_Client;
            set { id_Client = value; OnPropertyChanged(nameof(Id_Client)); }
        }
       
        private decimal amount;
        public decimal Amount
        {
            get => amount;
            set { amount = value; OnPropertyChanged(nameof(Amount)); }
        }
        private int rentalDays;
        public int RentalDays
        {
            get => rentalDays;
            set { rentalDays = value; OnPropertyChanged(nameof(RentalDays)); }
        }
        private int? id_Service1;
        public int? Id_Service1
        {
            get { return id_Service1; }
            set { id_Service1 = value; OnPropertyChanged(nameof(Id_Service1)); }
        }

        private int? id_Service2;
        public int? Id_Service2
        {
            get { return id_Service2; }
            set { id_Service2 = value; OnPropertyChanged(nameof(Id_Service2)); }
        }

        private int? id_Service3;
        public int? Id_Service3
        {
            get { return id_Service3; }
            set { id_Service3 = value; OnPropertyChanged(nameof(Id_Service3)); }
        }
    }
}
