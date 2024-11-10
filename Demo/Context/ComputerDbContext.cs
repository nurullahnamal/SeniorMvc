using Demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Demo.Context
{
	public class ComputerDbContext:DbContext
	{
		public ComputerDbContext() : base("VeriTabani")
		{
		}

		public DbSet<Computer> Computers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}