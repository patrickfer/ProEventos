using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Domain
{
    public class RedeSocial
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? EventoId { get; set; }
        public Palestrante Palestrante { get; set; }
        public Evento Evento { get; set; }
    }
}