using Microsoft.EntityFrameworkCore;

namespace ProjectAwesome.API.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> optoins) : base (optoins) {}

        public DbSet<Value> Values { get; set; }
    }
}