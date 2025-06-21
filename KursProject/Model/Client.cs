using KursProject.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing.IndexedProperties;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KursProject.Model
{
    public class Client:ViewModelBase
    {
        private int id_Client;
        public int Id_Client
        {
            get { return id_Client; }
            set { id_Client = value; OnPropertyChanged(nameof(Id_Client)); }
        }
        private string fio;
        public string FIO
        {
            get { return fio; }
            set
            {
                fio = value; OnPropertyChanged(nameof(FIO));
            }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(nameof(Email)); }
        }
        private int experience;
        public int Experience
        {
            get { return experience; }
            set { experience= value; OnPropertyChanged(nameof(Experience));}
        }
        private int validity_Period;
        public int Validity_Period
        {
            get { return validity_Period; }
            set { validity_Period = value; OnPropertyChanged(nameof(Validity_Period)); }
        }
        private DateTime birth_Date= DateTime.Now;
        public DateTime BirthDate
        {
            get => birth_Date;
            set {
                birth_Date = value; OnPropertyChanged(nameof(BirthDate));
            } 
        }
        private bool status;
        public bool Status
        {
            get => status;
            set
            {
                status = value; OnPropertyChanged(nameof(Status));
            }
        }
        private int count_Car;
        public int Count_Car
        {
            get => count_Car;
            set { count_Car = value; OnPropertyChanged(nameof(Count_Car)); }

        }
        private string number_License;
        public string Number_License
        {
            get { return number_License; }
            set { number_License = value; OnPropertyChanged(nameof(Number_License)); }

        }
        private int id_Discount;
        public int Id_Discount
        {
            get { return id_Discount; }
            set { id_Discount = value; OnPropertyChanged(nameof(Id_Discount)); }
        }
    }
}
