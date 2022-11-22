﻿using la_mia_pizzeria_static.Models;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.Data
{
    public class PizzaeriaDbContext : DbContext
    {
        public DbSet<Pizza> Pizze { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=la_mia_pizzeria;Integrated Security=True;Encrypt=false;");
        }
    }
}
