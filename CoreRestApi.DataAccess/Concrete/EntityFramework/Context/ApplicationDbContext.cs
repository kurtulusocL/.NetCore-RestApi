using CoreRestApi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreRestApi.DataAccess.Concrete.EntityFramework.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=.;Database=CoreRestApi;user Id=sa;Password=123");
            base.OnConfiguring(optionBuilder);
        }
        public DbSet<Country> Countries { get; set; }
    }
}
