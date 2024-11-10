using Ef_Demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Ef_Demo.Context
{
	public class ComputerDbContext:DbContext
	{
		public ComputerDbContext() : base("SatisDb")
		{

		}

		public DbSet<Computer> computers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}