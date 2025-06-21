using KursProject.Model;
using KursProject.Services;
using KursProject.Utills;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.ViewModel
{
    public class RentingViewModel:ViewModelBase
    {
        private RentingService rentService;
        private CarService carService;
        private ClientService clService;
        private DiscountService disService;
        private Servic_Service servic_Service;

        #region DisplayOperation
        /*Renting*/
        private ObservableCollection<Renting> rentList;
        public ObservableCollection<Renting> RentList
        {
            get { return rentList; }
            set { rentList = value; OnPropertyChanged(nameof(RentList)); }
        }


        /*Cars*/
        private List<Cars> carList = new();
        public List<Cars> CarList
        {
            get { return carList; }
            set { carList = value; OnPropertyChanged(nameof(CarList)); }
        }
        /*Clients*/
        private List<Client> clientList = new();
        public List<Client> ClientList
        {
            get { return clientList; }
            set { clientList = value; OnPropertyChanged(nameof(ClientList)); }
        }

        /*Discount*/
        private List<Servic> servList = new();
        public List<Servic> ServList
        {
            get { return servList; }
            set { servList = value; OnPropertyChanged(nameof(ServList)); }
        }

        private void LoadData()
        {
            RentList = new ObservableCollection<Renting>(rentService.GetAll());
            CarList = carService.GetAll();
            ClientList= clService.GetAll();
            servList = servic_Service.GetAll();
        }


        #endregion

        private Renting currentRent;
        public Renting CurrentRent
        {
            get { return currentRent; }
            set { currentRent = value; OnPropertyChanged(nameof(CurrentRent)); }
        }
        private string message;

       
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(nameof(Message)); }
        }


        public RentingViewModel()
        {
            rentService = new RentingService();
            carService = new CarService();
            clService = new ClientService();
            disService = new DiscountService();
            servic_Service = new Servic_Service();
            LoadData();
            CurrentRent = new Renting();
            saveCommand = new RelayCommandSQL(Save);
            updateCommand = new RelayCommandSQL(Update);
            deleteCommand = new RelayCommandSQL(Delete);

        }


        #region SaveOperation
        private RelayCommandSQL saveCommand;
        public RelayCommandSQL SaveCommand
        {
            get { return saveCommand; }
        }
        public void Save()
        {
            try
            {
                var IsSaved = rentService.Add(CurrentRent);
                LoadData();
                if (IsSaved)
                    Message = "Аренда  Оформлена";
                else
                    Message = "Ошибка оформления Аренды";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion

        #region UpdateOperation
        private RelayCommandSQL updateCommand;
        public RelayCommandSQL UpdateCommand
        {
            get { return updateCommand; }
        }
        public void Update()
        {
            try
            {
                var IsUpdated = rentService.Update(CurrentRent);
                LoadData();
                if (IsUpdated)
                    Message = "Аренда обновлен";
                else
                    Message = "Ошибка обновления Аренды";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion
        #region DeleteOperation
        private RelayCommandSQL deleteCommand;
        public RelayCommandSQL DeleteCommand
        {
            get { return deleteCommand; }
        }
        public void Delete()
        {
            try
            {
                var IsDeleted = rentService.Delete(CurrentRent.Id_Renting);
                LoadData();
                if (IsDeleted)
                    Message = "Аденда удалена";
                else
                    Message = "Ошибка удаления Аренды";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion
    }
}
