using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FullEventos.API.models;

namespace FullEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new EventoController[]{
            new Evento()
                 {
                EventoId = 1,
                Tema = " Angular 11 e .NET 5",
                Local = "itabaiana",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                ImagemURL = "Foto"
            },
            new Evento()
                 {
                EventoId = 2,
                Tema = " Angular 10",
                Local = "ita",
                Lote = "2º lote",
                QtdPessoas = 150,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
                ImagemURL = "Foto2"
            }
        };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return  _evento;

            

        }
        
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return  _evento.Where(evento=>evento.EventoId == id);

            

        }

    }
}
