using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Collections.Generic;

namespace SportsStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context;

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
        public EFProductRepository()
        {
            context = new EFDbContext();
        }
    }
}