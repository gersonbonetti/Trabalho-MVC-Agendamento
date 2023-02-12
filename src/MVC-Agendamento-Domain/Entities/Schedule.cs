﻿using MVC_Agendamento_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Entities {
    public class Schedule
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public bool ConfirmedQuery { get; set; }
        public EnumStatus Status { get; set; }

        public virtual Patient? Patient { get; set; }  //Será alterado para a entidade correta
        public virtual Doctor? Doctor { get; set; }
    }
}