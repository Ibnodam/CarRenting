using KursProject.Model;
using KursProject.Services;
using KursProject.Utills;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KursProject.ViewModel
{
    public class CarViewModel : ViewModelBase
    {
        private PriceService priceService;
        private CarService carService;

        #region DisplayOperation
        private ObservableCollection<Cars> carList;
        public ObservableCollection<Cars> CarList
        {
            get => carList;
            set { carList = value; OnPropertyChanged(nameof(CarList)); }
        }


        private List<PriceList> priceList = new();
        public List<PriceList> PrList
        {
            get => priceList;
            set { priceList = value; OnPropertyChanged(nameof(PrList)); }
        }

        private void LoadData()
        {
            CarList = new ObservableCollection<Cars>(carService.GetAll());
            PrList= priceService.GetAll();

        }

        #endregion
        private Cars currentCar;
        public Cars CurrentCar
        {
            get { return currentCar; }
            set { currentCar = value; OnPropertyChanged(nameof(CurrentCar)); }
        }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(nameof(Message)); }
        }
        public CarViewModel() {
            carService = new CarService();
            priceService = new PriceService();
            LoadData();
            CurrentCar = new Cars();
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
                var IsSaved = carService.Add(CurrentCar);
                LoadData();
                if (IsSaved)
                    Message = "Авто сохранен";
                else
                    Message = "Ошибка сохранения Авто";
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
                var IsUpdated = carService.Update(CurrentCar);
                LoadData();
                if (IsUpdated)
                    Message = "Авто обновлен";
                else
                    Message = "Ошибка обновления Авто";
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
                var IsDeleted = carService.Delete(CurrentCar.Id_Car);
                LoadData();
                if (IsDeleted)
                    Message = "Авто удален";
                else
                    Message = "Ошибка удаления Авто";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion
    }
}
