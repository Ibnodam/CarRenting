using KursProject.Model;
using KursProject.Services;
using KursProject.Utills;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KursProject.ViewModel
{
    public class PriceViewModel:ViewModelBase
    {
        private PriceService priceService;

        #region DisplayOperation
        private ObservableCollection<PriceList> priceList;
        public ObservableCollection<PriceList> PrList
        {
            get => priceList;
            set { priceList = value; OnPropertyChanged(nameof(PrList)); }
        }
        private void LoadData()
        {
            PrList = new ObservableCollection<PriceList>(priceService.GetAll());
        }
        #endregion
        private PriceList currentPrice;
        public PriceList CurrentPrice
        {
            get { return currentPrice; }
            set { currentPrice = value; OnPropertyChanged(nameof(CurrentPrice)); }
        }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(nameof(Message)); }
        }
        public PriceViewModel()
        {
            priceService = new PriceService();
           
            LoadData();
            CurrentPrice= new PriceList();
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
                var IsSaved = priceService.Add(CurrentPrice);
                LoadData();
                if (IsSaved)
                    Message = "Стоимость сохранена";
                else
                    Message = "Ошибка сохранения Стоимости";
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
                var IsUpdated = priceService.Update(CurrentPrice);
                LoadData();
                if (IsUpdated)
                    Message = "Стоимость обновлен";
                else
                    Message = "Ошибка обновления Стоимости";
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
                var IsDeleted = priceService.Delete(CurrentPrice.Id_Price);
                LoadData();
                if (IsDeleted)
                    Message = "Стоимость удален";
                else
                    Message = "Ошибка удаления Стоимости";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion


    }
}
