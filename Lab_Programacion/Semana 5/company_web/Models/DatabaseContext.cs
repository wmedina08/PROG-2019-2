using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace company_web.models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        
        public DbSet<producto> productos { get; set; }

    }
}