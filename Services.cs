using FastReportAspNetCoreMVC5.Data;
using FastReportDotNetCore5MVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace FastReportDotNetCore5MVC
{
    public class Services
    {
        private readonly ApplicationDbContext _context;
        public Services(ApplicationDbContext context)
        {
            this._context = context;
        }
        public List<Product> GetAllProduct()
        {
            var products = _context.Products.ToList();
            return products;
        }
    }
}
