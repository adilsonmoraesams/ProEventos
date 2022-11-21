using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Contratos
{
    public interface IEventoService
    {
        Task<Evento> AddEventos(Evento model);
        Task<Evento> Updateventos(int eventoId, Evento model);
        Task<bool> DeleteEventos(int eventoId);
        
        // Listas
        Task<Evento[]>  GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Evento[]>  GetAllEventosAsync(string tema, bool includePalestrantes = false);
        Task<Evento>  GetAllEventosByIdAsync(int EventoId, bool includePalestrantes = false);
    }
}