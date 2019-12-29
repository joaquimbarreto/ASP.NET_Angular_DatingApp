using Microsoft.EntityFrameworkCore;
using UdemyDatingApp.Models;

namespace UdemyDatingApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Value> Values { get; set; }
    }
}