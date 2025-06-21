using KursProject.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Model
{
    public class Cars : ViewModelBase
    {
        private int id_Car;
        public int Id_Car
        {
            get { return id_Car; }
            set { id_Car = value; OnPropertyChanged(nameof(Id_Car)); }
        }
        private int id_Price;
        public int Id_Price
        {
            get { return id_Price; }
            set { id_Price = value; OnPropertyChanged(nameof(Id_Price)); }
        }
        private string marka;
        public string Marka
        {
            get { return marka; }
            set { marka = value; OnPropertyChanged(nameof(Marka)); }
        }
        private string model;
        public string Model
        {
            get { return model; }
            set
            {
                model = value; OnPropertyChanged(nameof(Model));
            }
        }
        private int year_realize;
        public int Year_Realize
        {
            get => year_realize;
            set
            {
                year_realize = value;
                OnPropertyChanged(nameof(Year_Realize));
            }
        }
        private bool relyability = true;
        public bool Reliability
        {
            get { return relyability; }
            set { relyability = value; OnPropertyChanged(nameof(Reliability)); }
        }
        private string type_Body;
        public string Type_Body
        {
            get { return type_Body; }
            set { type_Body = value; OnPropertyChanged(nameof(Type_Body)); }
        }
        private string number_Car;
        public string Number_Car
        {
            get { return number_Car; }
            set { number_Car = value; OnPropertyChanged(nameof(Number_Car)); }
        }
    }
}
