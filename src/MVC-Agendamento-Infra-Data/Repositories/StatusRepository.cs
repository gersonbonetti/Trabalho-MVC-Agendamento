﻿using MVC_Agendamento_Domain.Contract.Repositories;
using MVC_Agendamento_Domain.Contracts.Repositories;
using MVC_Agendamento_Domain.Contracts.Repository;
using MVC_Agendamento_Domain.Entities;
using MVC_Agendamento_Infra_Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MVC_Agendamento_Infra_Data.Repositories {
    public class AddressRepository : BaseRepository<Address>, IAddressRepository {
        private readonly SQLServerContext _context;
        public AddressRepository(SQLServerContext context) : base(context) {
            this._context = context;

        }
    }
}
