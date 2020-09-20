using Microsoft.EntityFrameworkCore;
using thard.projects.nca.datingapp.Models;
namespace thard.projects.nca.datingapp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Value> Values { get; set; }
    }
}