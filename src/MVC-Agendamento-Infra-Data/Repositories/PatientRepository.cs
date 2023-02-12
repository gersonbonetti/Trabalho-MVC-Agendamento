using MVC_Agendamento_Domain.Contract.Repositories;
using MVC_Agendamento_Domain.Entities;
using MVC_Agendamento_Infra_Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Infra_Data.Repositories {
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository {
        private readonly SQLServerContext _context;
        public PatientRepository(SQLServerContext context) : base(context)
        {
            this._context = context;

        }
    }
}
