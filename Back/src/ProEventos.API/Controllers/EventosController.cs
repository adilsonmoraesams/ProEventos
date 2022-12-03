using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Application.Contratos;
using ProEventos.Domain;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly IEventoService _eventoService;

        public EventosController(IEventoService eventoService)
        {
            this._eventoService = eventoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var eventos = await this._eventoService.GetAllEventosAsync();
                if (eventos == null)
                {
                    return NotFound("Nenhum evento encontrado.");
                }

                return Ok(eventos);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar eventos. Erro: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var evento = await this._eventoService.GetEventoByIdAsync(id);
                if (evento == null)
                {
                    return NotFound("Nenhum evento encontrado.");
                }

                return Ok(evento);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar eventos. Erro: {ex.Message}");
            }
        }


        [HttpGet("{tema}/tema")]
        public async Task<IActionResult> GetByTema(string tema)
        {
            try
            {
                var evento = await this._eventoService.GetAllEventosByTemaAsync(tema);
                if (evento == null)
                {
                    return NotFound("Nenhum evento encontrado.");
                }

                return Ok(evento);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar eventos. Erro: {ex.Message}");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Post(Evento model)
        {
            try
            {
                var evento = await _eventoService.AddEvento(model);
                if (evento == null)
                {
                    return BadRequest("Erro ao tentar adicionar um novo evento.");
                }

                return Ok(evento);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar adicionar um evento. Erro: {ex.Message}");
            }
        }


        [HttpPut]
        public async Task<IActionResult> Put(int id, Evento model)
        {
            try
            {
                var evento = await _eventoService.UpdateEvento(id, model);
                if (evento == null)
                {
                    return BadRequest("Erro ao tentar adicionar um novo evento.");
                }

                return Ok(evento);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar atualizar um evento. Erro: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (!await _eventoService.DeleteEvento(id))
                {
                    return BadRequest("Nenhum evento encontrado.");
                }

                return Ok("Evento deletado com sucesso!");
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar eventos. Erro: {ex.Message}");
            }
        }


    }
}
