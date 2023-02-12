﻿using MVC_Agendamento_Domain.Contract.Repositories;
using MVC_Agendamento_Domain.DTO;
using MVC_Agendamento_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Contracts.Repository {
    public interface IStatusRepository : IBaseRepository<Status> {
    }
}
