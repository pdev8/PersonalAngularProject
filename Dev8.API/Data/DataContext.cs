using Dev8.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Dev8.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values {get; set;}
    }
}