using MVC_Agendamento_Domain.Entities;
using MVC_Agendamento_Domain.IRepositories;
using MVC_Agendamento_Infra_Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Infra_Data.Repositories {
    public class ServiceRepository : BaseRepository<Service>, IServiceRepository{


        private readonly SQLServerContext _context;

        public ServiceRepository(SQLServerContext context) : base(context) {
            _context = context;
        }


    }
}
