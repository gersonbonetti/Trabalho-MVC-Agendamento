using MVC_Agendamento_Domain.Contract.Repositories;
using MVC_Agendamento_Domain.Entities;
using MVC_Agendamento_Infra_Data.Context;
using MVC_Agendamento_Infra_Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Infra_Data.Repositoriess {
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        private readonly SQLServerContext _context;
        public DoctorRepository(SQLServerContext context) : base(context)
        {
            this._context = context;
        }
    }
}
