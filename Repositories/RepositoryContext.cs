﻿using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repositories.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class RepositoryContext : IdentityDbContext<IdentityUser>
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Order> Orders { get; set; }
		public RepositoryContext(DbContextOptions<RepositoryContext> options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//modelBuilder.ApplyConfiguration(new ProductConfig());
			//modelBuilder.ApplyConfiguration(new CategoryConfig());

			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

			//Yukarıda her config' imizi teker teker tanımlamak yerine assembly otomatik algılayıp uygulayacak
		}


	}
}