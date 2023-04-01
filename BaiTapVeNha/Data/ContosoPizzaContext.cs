﻿using System;
using BaiTapVeNha.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiTapVeNha.Data
{
	public class ContosoPizzaContext : DbContext
	{
		public ContosoPizzaContext()
		{
		}
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BaiTapVeNha");
        }
    }
}

