using MVC_Agendamento_Domain.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Entities
{
    public class Agenda
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public bool ConsultaConfirmada { get; set; }
        public EnumStatus Status { get; set; }
        public string Observacoes { get; set; }

        public virtual string? Paciente { get; set; }  //Será alterado para a entidade correta
        public virtual string? Medico { get; set; }
    }
}
