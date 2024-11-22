using Cheesse.Models;
using Microsoft.EntityFrameworkCore;

namespace Cheesse.Data
{
	public class CheesseDbContext : DbContext
	{
		protected readonly IConfiguration _configuration;

		public DbSet<User> Users { get; set; }

		public CheesseDbContext(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DbConnectionString"));
		}
	}
}
