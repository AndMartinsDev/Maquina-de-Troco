using Microsoft.EntityFrameworkCore;

namespace MqTroco.Data
{
	public class SystemContext : DbContext
	{
		public SystemContext(DbContextOptions options) : base(options)
		{

		}

		public SystemContext() : base()
		{

		}

		public DbSet<Moeda> Moeda { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string conn = "Server=localhost\\SQLEXPRESS01;Database=DbMaqTroco;Trusted_Connection=True;";

			optionsBuilder.UseSqlServer(conn);

			base.OnConfiguring(optionsBuilder);

		}

	}

}
