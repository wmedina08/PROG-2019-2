using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Invoice_web_2.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Invoice> Invoices { get; set; }

    }
}