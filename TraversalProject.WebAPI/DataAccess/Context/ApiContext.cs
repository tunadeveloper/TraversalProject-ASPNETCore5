using Microsoft.EntityFrameworkCore;
using TraversalProject.WebAPI.DataAccess.Entities;

namespace TraversalProject.WebAPI.DataAccess.Context
{
    public class ApiContext:DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-97JKMRT\\SQLEXPRESS;database=TraversalApiDB;integrated security=true;");
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
