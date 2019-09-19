using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using student_app.Models;

namespace student_app.models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        
        public DbSet<student> students { get; set; }

    }
}