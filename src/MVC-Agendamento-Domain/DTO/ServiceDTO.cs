using MVC_Agendamento_Domain.Entities;
using MVC_Agendamento_Domain.Utils.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.DTO {
    public class ServiceDTO {

        [DisplayName("Id")]
        public int id { get; set; }

        [DisplayName("Id Agenda")]
        public int scheduleId { get; set; }

        [DisplayName("Numero do Atendimento")]
        public int numberService { get; set; } //coomeça em 2500

        [DisplayName("Avaliação")]
        public string? evaluation { get; set; }

        [DisplayName("Id Paciente")]
        public int patientId { get; set; }

        [DisplayName("Id Médico")]
        public int doctorID { get; set; }

        public virtual string? patient { get; set; }

        public virtual string? doctor { get; set; }

        [DisplayName("Data")]
        public DateTime date { get; set; }

        [DisplayName("Status")]
        public EnumStatus status { get; set; }


        public Service mapToEntity() {
            return new Service {
                Id = id,
                ScheduleId = scheduleId,
                Evaluation = evaluation,
                PatientId = patientId,
                DoctorID = doctorID,
                Patient = patient,
                Doctor = doctor,
                NumberService = numberService,
                Date = date,
                Status = status,
            };
        }
        public ServiceDTO mapToDTO(Service service) {

            return new ServiceDTO {

                id = service.Id,
                scheduleId = service.ScheduleId,
                evaluation = service.Evaluation,
                patientId = service.PatientId,
                doctorID = service.DoctorID,
                patient = service.Patient,
                doctor = service.Doctor,
                numberService = service.NumberService,
                date = service.Date,
                status = service.Status,
            };

        }

    }
}
