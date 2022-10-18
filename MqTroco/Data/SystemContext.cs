using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MqTroco.Data
{
	[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
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
			string conn = "Server=localhost\\SQLEXPRESS01;Database=DbMaquinaTroco;Trusted_Connection=True;";

			optionsBuilder.UseSqlServer(conn);

			base.OnConfiguring(optionsBuilder);

		}

		private string GetDebuggerDisplay()
		{
			return ToString();
		}
	}

}
