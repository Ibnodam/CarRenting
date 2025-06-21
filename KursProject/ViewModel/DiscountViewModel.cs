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
     class DiscountViewModel:ViewModelBase
    {
        private DiscountService disService;
        private ObservableCollection<Discount> discounts;
        public ObservableCollection<Discount> DisList
        {
            get { return discounts; }
            set { discounts = value; OnPropertyChanged(nameof(discounts)); }
        }
        private void LoadData()
        {
            DisList= new ObservableCollection<Discount>(disService.GetAll());
        }
        private Discount currentDisc;
        public Discount CurrentDiscount
        {
            get => currentDisc;
            set { currentDisc = value; OnPropertyChanged(nameof(CurrentDiscount)); }
        }
        private string message;

    
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(nameof(Message)); }
        }
        public DiscountViewModel()
        {
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
                var isSaved = disService.Add(CurrentDiscount);
                LoadData();
                if (isSaved)
                {
                    Message = "Скидка сохранена";
                }
                else
                {
                    Message = "Ошибка сохранениия Скидки";
                }
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
                var IsUpdated = disService.Update(CurrentDiscount);
                LoadData();
                if (IsUpdated)
                    Message = "Скидка обновлен";
                else
                    Message = "Ошибка обновления Скидки";

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
                var IsDeleted = disService.Delete(CurrentDiscount.Id_Discount);
                LoadData();
                if (IsDeleted)
                    Message = "Скидка удален";
                else
                    Message = "Ошибка удаления Скидки";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion
    }
}
