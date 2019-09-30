using Microsoft.EntityFrameworkCore;
using System;

namespace Shared
{
    public class Class1 : DbContext
    {
        public DbSet<table> table { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DB1;Database=deleteme123;Integrated Security=true;");
        }
    }

    public class table
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
