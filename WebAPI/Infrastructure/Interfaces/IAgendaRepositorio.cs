﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IAgendaRepositorio : IBaseRepositorio<Agenda>
    {
        Task<Agenda> ObterTitulo(string titulo);
    }
}
