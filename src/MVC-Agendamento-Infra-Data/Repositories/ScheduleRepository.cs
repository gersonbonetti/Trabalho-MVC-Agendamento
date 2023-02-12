using MVC_Agendamento_Domain.Contract.Repositories;
using MVC_Agendamento_Domain.Entities;
using MVC_Agendamento_Infra_Data.Context;

namespace MVC_Agendamento_Infra_Data.Repositories {
    public class ScheduleRepository : BaseRepository<Schedule>, IScheduleRepository {
        private readonly SQLServerContext _context;

        public ScheduleRepository(SQLServerContext context) : base(context) {
            _context = context;
        }



    }
}