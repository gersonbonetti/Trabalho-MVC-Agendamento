using MVC_Agendamento_Domain;
using MVC_Agendamento_Domain.Contract.Repositories;
using MVC_Agendamento_Domain.Entities;
using Register.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Domain.Contracts.Repositories
{
    public interface IConditionRepository : IBaseRepository<Condition> {
    }
}
