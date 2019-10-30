using Microsoft.EntityFrameworkCore;

namespace WOI
{
    public class _databaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=.\SQLEXPRESS01;initial catalog=WOIDB;integrated security=True;");
        }

        public DbSet<WorkOrder> WorkOrders { get; set; }
    }
}