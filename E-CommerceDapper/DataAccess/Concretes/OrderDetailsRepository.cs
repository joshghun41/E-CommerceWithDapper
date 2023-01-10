using Dapper;
using E_CommerceDapper.DataAccess.Abstractions;
using E_CommerceDapper.DataAccess.Entites;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDapper.DataAccess.Concretes
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {

        public string ConnectionString { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }

        public OrderDetailsRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }

        public void Add(OrderDetails data)
        {

            using (var connection = new SqlConnection(ConnectionString))
            {
                var sql = @"INSERT INTO OrderDetails([OrderId],[ProductID],[UnitPrice],[Quantity],[Discount])
                            VALUES(@OrderID,@ProductID,@UnitPrice,@Quantity,@Discount)";

             

                connection.Execute(sql, new{ 
                
                    data.OrderID,
                    data.ProductId,
                    data.UnitPrice,
                    data.Quantity,
                    data.Discount
                
                });

            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetails Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetails> GetAll()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var sql = @"SELECT * FROM OrderDetails";

                var orders = connection.Query<OrderDetails>(sql);
                return orders;
            }

        }

        public void Update(OrderDetails data)
        {
            throw new NotImplementedException();
        }
    }
}
