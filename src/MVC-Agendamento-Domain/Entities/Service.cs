using MVC_Agendamento_Domain.Utils.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Entities {
    public class Service {

        [DisplayName("Id")]
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public int NumberService { get; set; }
        public string Evaluation { get; set; }
        public int PatientId { get; set; }
        public int DoctorID { get; set; }
        public virtual string? Patient { get; set; }
        public virtual string? Doctor { get; set; }
        public DateTime Date { get; set; }
        public EnumStatus Status { get; set; }

    }
}
