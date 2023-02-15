using MVC_Agendamento_Domain;
using MVC_Agendamento_Infra_Data.Context;
using MVC_Agendamento_Infra_Data.Repositories;
using Register.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Infra_Data
{
    public class ConditionRepository : BaseRepository<Condition>, IConditionRepository
    {
        private readonly SQLServerContext _context;
        public ConditionRepository(SQLServerContext context) : base(context)
        {
            this._context = context;
        }
    }
}
