using MVC_Agendamento_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Entities {
    public class Service {

        public int Id { get; set; }
        public int IdSchedule { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
        public virtual Patient? Patient { get; set; }
        public virtual Doctor? Doctor { get; set; }
        public int ServiceNumbe { get; set; }
        public DateTime Date { get; set; }   
        public EnumStatus Status { get; set; }
        public string? Evaluation { get; set; }

        public int MedicalRecord { get; set; }

    }
}
