using Microsoft.EntityFrameworkCore;
using MVC_Agendamento_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Infra_Data.Context
{
    public class SQLServerContext : DbContext
    {
		public SQLServerContext() : base() { }

		public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options) { }

		public DbSet<Schedule> Schedules { get; set; }
	}
}
