using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace company_web.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }

    }
}