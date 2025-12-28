using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TraversalProject.SignalRLayer.DataAccess.Entities;

namespace TraversalProject.SignalRLayer.DataAccess.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {
            
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
