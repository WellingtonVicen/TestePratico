﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class AgendaDTO
    {
        public long Id { get; set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        [DisplayFormat(DataFormatString = "{{0:MMM dd, yyyy}}")]
        public DateTime Data { get; private set; }

        public AgendaDTO() { }
        
        public AgendaDTO(long id, string titulo, string descricao, DateTime data)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Data = data;
        }

       
    }
}
