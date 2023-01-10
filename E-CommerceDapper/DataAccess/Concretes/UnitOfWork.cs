using E_CommerceDapper.DataAccess.Abstractions;
using E_CommerceDapper.DataAccess.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDapper.DataAccess.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository CategoryRepository => new CategoryRepository();

        public IProductRepository ProductRepository => new ProductRepository();

        public IOrderDetailsRepository OrderDetailsRepository => new OrderDetailsRepository();
    }
}
