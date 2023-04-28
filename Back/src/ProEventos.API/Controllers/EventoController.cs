using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _eventos = new Evento[] {

                    new Evento() {
                        EventoId = 1,
                        Tema = "Angula 11 e .NET 5",
                        Local = "Brasília",
                        Lote = "1º Lote",
                        Qtdpessoas = 250,
                        DataEvento = DateTime.Now.AddDays(2).ToString(),
                        imagemURL = "foto.png"
                    },
                    new Evento() {
                        EventoId = 2,
                        Tema = "Angula e suas novidades",
                        Local = "Aracaju",
                        Lote = "2º Lote",
                        Qtdpessoas = 350,
                        DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                        imagemURL = "foto2 .png"
                    }
            };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _eventos.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com Id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com Id = {id}";
        }
    }
}
