using Microsoft.EntityFrameworkCore;
using netCoreApp1.Entities;
namespace netCoreApp1.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base (options)
        {

        }

        public DbSet<AppUser> Users{get;set;}
    }
}