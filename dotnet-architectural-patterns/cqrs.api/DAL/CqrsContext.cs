using cqrs.api.Models;
using Microsoft.EntityFrameworkCore;

namespace cqrs.api.DAL
{
    public class CqrsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Data Source=DESKTOP-2H4R752;Initial Catalog=cqrs.db;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False");
    }
}
