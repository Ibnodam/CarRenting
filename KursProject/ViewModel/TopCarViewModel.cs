using KursProject.Model;
using KursProject.Services;
using KursProject.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.ViewModel
{
    public class TopCarViewModel:ViewModelBase
    {
        private TopCarService _service;
        private List<TopCars>  topList = new();

      
        public List<TopCars> TopList
        {
            get => topList;
            set { topList = value; OnPropertyChanged(nameof(topList)); }
        }
        private void LoadData()
        {
            TopList = _service.GetAll();
        }
        public TopCarViewModel()
        {
            _service = new TopCarService();
            LoadData();
        }

    }
}
