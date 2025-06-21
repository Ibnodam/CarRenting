using KursProject.Model;
using KursProject.Services;
using KursProject.Utills;
using KursProject.View;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.ViewModel
{
    public class ClientViewModel : ViewModelBase
    {
        private ClientService clService;

        #region DisplayOperation
        private ObservableCollection<Client> clList;
        public ObservableCollection<Client> ClList
        {
            get => clList;
            set { clList = value; OnPropertyChanged(nameof(ClList)); }
        }
        private void LoadData()
        {
            ClList = new ObservableCollection<Client>(clService.GetAll());
           
        }
        #endregion
        private Client currentClient;
        public Client CurrentClient
        {
            get { return currentClient; }
            set { currentClient = value; OnPropertyChanged(nameof(CurrentClient)); }
        }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(nameof(Message)); }
        }

        public ClientViewModel()                                    
        {
            clService = new ClientService();
            LoadData();
            CurrentClient = new Client();
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
                var isSaved = clService.Add(CurrentClient);
                LoadData();
                if (isSaved)
                {
                    Message = "Клиент охранен";
                }
                else
                {
                    Message = "Ошибка сохранениия клиента";
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
                var IsUpdated = clService.Update(CurrentClient);
                LoadData();
                if (IsUpdated)
                    Message = "Клиент обновлен";
                else
                    Message = "Ошибка обновления Клиента";

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
                var IsDeleted = clService.Delete(CurrentClient.Id_Client);
                LoadData();
                if (IsDeleted)
                    Message = "Клиент удален";
                else
                    Message = "Ошибка удаления Клиента";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion

    }
}

