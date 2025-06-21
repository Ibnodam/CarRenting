using KursProject.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Model
{
    public class Servic: ViewModelBase
    {
        private int id_Service;
        public int Id_Service
        {
            get { return id_Service; }
            set { id_Service = value; OnPropertyChanged(nameof(Id_Service)); }

        }
        private string name_Service;
        public string Name_Service
        {
            get { return name_Service; }
            set { name_Service = value; OnPropertyChanged(nameof(Name_Service)); }

        }
        private decimal price_Service;
        public decimal Price_Service
        {
            get { return price_Service; }
            set { price_Service = value; OnPropertyChanged(nameof(Price_Service)); }

        }

    }
}
