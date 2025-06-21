using KursProject.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KursProject.ViewModel
{
    public class NavigationViewModel:ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }
        public ICommand HomeCommand { get; set; }
        public ICommand ClientCommand { get; set; }
        public ICommand PriceCommand { get; set; }
        public ICommand CarCommand { get; set; }
        public ICommand ServiceCommand { get; set; }
        public ICommand RentingCommand { get; set; }
        public ICommand PayingCommand { get; set; }
        public ICommand TopCarCommand { get; set; }



        private void Home(object obj) => CurrentView = new HomeViewModel();
        private void ClientPage(object obj) =>CurrentView= new ClientViewModel();
        private void PricePage(object obj)=> CurrentView = new PriceViewModel();
        private void CarPage(object obj) => CurrentView = new CarViewModel();
        private void ServicePage(object obj) => CurrentView = new ServiceViewModel();
        private void RentingPage(object obj) => CurrentView = new RentingViewModel();
        private void PayingPage(object obj) => CurrentView = new PayingViewModel();
        private void TopCarPage(object obj) => CurrentView = new TopCarViewModel();



        public NavigationViewModel()
        {
            HomeCommand= new RelayCommand(Home);
            ClientCommand= new RelayCommand(ClientPage);
            PriceCommand= new RelayCommand(PricePage);
            CarCommand = new RelayCommand(CarPage);
            ServiceCommand = new RelayCommand(ServicePage);
            RentingCommand = new RelayCommand(RentingPage);
            PayingCommand = new RelayCommand(PayingPage);
            TopCarCommand = new RelayCommand(TopCarPage);

            CurrentView = new HomeViewModel();


        }
    }
}
