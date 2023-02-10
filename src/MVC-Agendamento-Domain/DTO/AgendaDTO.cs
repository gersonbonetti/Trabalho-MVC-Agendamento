using MVC_Agendamento_Domain.Entities;
using MVC_Agendamento_Domain.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.DTO
{
    public class AgendaDTO
    {
        public int id { get; set; }
        public int pacienteId { get; set; }
        public int medicoId { get; set; }
        public bool consultaConfirmada { get; set; }
        public EnumStatus status { get; set; }

        public virtual string? paciente { get; set; }  //Será alterado para a entidade correta
        public virtual string? medico { get; set; }

        public Agenda mapToEntity()
        {
            return new Agenda
            {
                Id = this.id,
                PacienteId = this.pacienteId,
                MedicoId = this.medicoId,
                ConsultaConfirmada = this.consultaConfirmada,
                Status = this.status,
            };
        }
        public AgendaDTO mapToDTO(Agenda agenda)
        {
            return new AgendaDTO
            {
                id = agenda.Id,
                pacienteId = agenda.PacienteId,
                medicoId = agenda.MedicoId,
                consultaConfirmada = agenda.ConsultaConfirmada,
                status = agenda.Status,
            };
        }
    }
}
