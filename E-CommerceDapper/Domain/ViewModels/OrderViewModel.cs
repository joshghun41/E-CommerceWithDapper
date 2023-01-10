using E_CommerceDapper.DataAccess.Entites;
using E_CommerceDapper.Domain.Commands;
using E_CommerceDapper.Domain.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace E_CommerceDapper.Domain.ViewModels
{
    public class OrderViewModel:BaseViewModel
    {

		private TextBox q;

		public TextBox Q
		{
			get { return q; }
			set { q = value; OnPropertyChanged(); }
		}


		private OrderDetails order;

		public OrderDetails Order
        {
			get { return order; }
			set { order = value; OnPropertyChanged(); }
		}

		

		public RelayCommand	SubmitCommand { get; set; }
		public OrderViewModel(Product product)
		{
			Order = new OrderDetails();

			//var p = new Product();
			//var viewm = new ProductInfoViewModel(p);
			//Order.UnitPrice = viewm.Product.UnitPrice;
			//Order.Quantity = viewm.Product.UnitsInStock;
			Order.UnitPrice = product.UnitPrice;
			Order.Quantity = product.UnitsInStock;
			Order.Discount = 0.2f;
			Order.OrderID = 10248;
			Order.ProductId = 5;

			//Order.Quantity = product.UnitsInStock;
			SubmitCommand = new RelayCommand((o) =>
			{
				//App.DB.OrderDetailsRepository.Add(Order);

				//short textboxquantity = short.Parse(Q.Text);


				App.DB.OrderDetailsRepository.Add(Order);

				var vm = new OrderDetailsViewModel();
				var view = new OrderDetailsWindow();
				view.DataContext = vm;

				view.Show();


			});
		}

	}
}
