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
    public class PayingViewModel :ViewModelBase
    {
        private RentingService rentingService;
        private PayingService payService;
        #region DisplayOperation
        private ObservableCollection<Paying> payList;
        public ObservableCollection<Paying> PayList
        {
            get => payList;
            set { payList = value; OnPropertyChanged(nameof(PayList)); }
        }
        private List<Renting> rentList = new();
        public List<Renting> RentList
        {
            get => rentList;
            set { rentList = value; OnPropertyChanged(nameof(RentList)); }
        }


        private void LoadData()
        {
            PayList = new ObservableCollection<Paying>(payService.GetAll());
            RentList= rentingService.GetAll();
        }
        #endregion
        private Paying currentPay;
        public Paying CurrentPay
        {
            get { return currentPay; }
            set { currentPay = value; OnPropertyChanged(nameof(CurrentPay)); }
        }
        private string message;

       

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(nameof(Message)); }
        }
        public PayingViewModel()
        {
            payService = new PayingService();
            rentingService = new RentingService();
            LoadData();
            CurrentPay = new Paying();
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
                var IsSaved = payService.Add(CurrentPay);
                LoadData();
                if (IsSaved)
                    Message = "Оплата сохранена";
                else
                    Message = "Ошибка сохранения Оплаты";
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
                var IsUpdated = payService.Update(CurrentPay);
                LoadData();
                if (IsUpdated)
                    Message = "Оплата обновлен";
                else
                    Message = "Ошибка обновления Оплаты";
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
                var IsDeleted = payService.Delete(CurrentPay.Id_Paying);
                LoadData();
                if (IsDeleted)
                    Message = "Оплата удалена";
                else
                    Message = "Ошибка удаления Оплати";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion

    }
}
