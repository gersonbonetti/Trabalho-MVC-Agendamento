using MVC_Agendamento_Domain.Entities;
using MVC_Agendamento_Domain.IRepositories;
using MVC_Agendamento_Infra_Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Infra_Data.Repositories
{
    public class AgendaRepository : BaseRepository<Agenda>, IAgendaRepository
    {
        private readonly SQLServerContext _context;

        public AgendaRepository(SQLServerContext context) : base(context) 
        {
        }
    }
}
