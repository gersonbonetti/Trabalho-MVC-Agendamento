using MVC_Agendamento_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.DTO {
    internal class ServiceDTO {

        public int id { get; set; }
        public int idSchedule { get; set; }
        public int idPatient { get; set; }
        public int idDoctor { get; set; }
        public virtual string? patient { get; set; }
        public virtual string? doctor { get; set; }
        public int numberService { get; set; }
        public DateTime date { get; set; }


        public Service mapToEntity() {
            return new Service {
                Id = id,
                IdSchedule = idSchedule,
                IdPatient = idPatient,
                IdDoctor = idDoctor,
                Patient = patient,
                Doctor = doctor,
                NumberService = numberService,
                Date = date,
            };
        }
        public ServiceDTO mapToDTO(Service service) {
            return new ServiceDTO {
                idSchedule = service.IdSchedule,
                idPatient = service.IdPatient,
                idDoctor = service.IdDoctor,
                patient = service.Patient,
                doctor = service.Doctor,
                numberService = service.NumberService,
                date = service.Date,
            };

        }

    }
}
