using E_CommerceDapper.DataAccess.Entites;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDapper.Domain.ViewModels
{
    public class OrderDetailsViewModel : BaseViewModel
    {

        private ObservableCollection<OrderDetails> allOrderDetails;

        public ObservableCollection<OrderDetails> AllOrderDetails
        {
            get { return allOrderDetails; }
            set { allOrderDetails = value; OnPropertyChanged(); }
        }


        public OrderDetailsViewModel()
        {
            var allfromdatabase = App.DB.OrderDetailsRepository.GetAll();
            AllOrderDetails = new ObservableCollection<OrderDetails>(allfromdatabase);
        }

    }
}
