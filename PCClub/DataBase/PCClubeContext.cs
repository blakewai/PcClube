using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCClub.DataBase
{
    class PCClubeContext : DbContext
    {
        public static PCClubeContext context;

        public PCClubeContext()
        {
            Database.EnsureCreated();
        }

        public const string _stringConnection = "Data Source=DESKTOP-A3PD9EO;" +
                                                "Initial Catalog=PcClube;" +
                                                "Integrated Security=True;" +
                                                "Trust Server Certificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_stringConnection);
        }

        public DbSet<Tables.User> Users { get; set; }
        public DbSet<Tables.Role> Role { get; set; }
        public DbSet<Tables.BankCards> BankCards { get; set; }
    }
}
