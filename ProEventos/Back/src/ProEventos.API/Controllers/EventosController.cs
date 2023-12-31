﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Persistence;
using ProEventos.Domain;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly ProEventosContext _context;
        public EventosController(ProEventosContext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public IEnumerable <Evento> Get()
        {
            return _context.Eventos;
            
        }

         [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(
                evento => evento.Id == id);
            
        }

         [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut]
        public string Put()
        {
            return "Exemplo de Put";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Exemplo de Delete";
        }
    }
}
