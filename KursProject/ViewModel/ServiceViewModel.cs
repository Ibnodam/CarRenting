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
    public class ServiceViewModel: ViewModelBase
    {
        private Servic_Service serService;
        #region DisplayOperation
        private ObservableCollection<Servic> servList;
        public ObservableCollection<Servic> ServList
        {
            get => servList;
            set { servList = value; OnPropertyChanged(nameof(ServList)); }
        }
        private void LoadData()
        {
            ServList = new ObservableCollection<Servic>(serService.GetAll());
        }
        #endregion
        private Servic currentService;
        public Servic CurrentService
        {
            get { return currentService; }
            set { currentService = value; OnPropertyChanged(nameof(CurrentService)); }
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(nameof(Message)); }
        }
        public ServiceViewModel()
        {
            serService = new Servic_Service();
            

            LoadData();
            CurrentService = new Servic();
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
                var IsSaved = serService.Add(CurrentService);
                LoadData();
                if (IsSaved)
                    Message = "Услуга сохранена";
                else
                    Message = "Ошибка сохранения Услуги";
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
                var IsUpdated = serService.Update(CurrentService);
                LoadData();
                if (IsUpdated)
                    Message = "Услуга обновлен";
                else
                    Message = "Ошибка обновления Услуги";
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
                var IsDeleted = serService.Delete(CurrentService.Id_Service);
                LoadData();
                if (IsDeleted)
                    Message = "Услуга удален";
                else
                    Message = "Ошибка удаления Услуги";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion
    }
}
