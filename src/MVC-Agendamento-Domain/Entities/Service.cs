using MVC_Agendamento_Domain.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Entities {
    internal class Atendimento {

        public int Id { get; set; }

        public int IdSchedule { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
        public DateTime Date { get; set; }






    }
}
