
using FastReportDotNetCore5MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FastReportAspNetCoreMVC5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}