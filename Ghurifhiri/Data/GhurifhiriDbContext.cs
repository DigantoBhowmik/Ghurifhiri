using System;
using Ghurifhiri.Models;
using Microsoft.EntityFrameworkCore;

namespace Ghurifhiri.Data
{
	public class GhurifhiriDbContext : DbContext
	{
		public GhurifhiriDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<User> Users { get; set; }
	}
}

