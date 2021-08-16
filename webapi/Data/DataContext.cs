using webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace webapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}