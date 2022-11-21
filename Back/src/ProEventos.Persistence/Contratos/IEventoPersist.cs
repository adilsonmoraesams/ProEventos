using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    { 
        // Evento
        Task<Evento[]>  GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Evento[]>  GetAllEventosAsync(string tema, bool includePalestrantes = false);
        Task<Evento>  GetAllEventosByIdAsync(int EventoId, bool includePalestrantes = false);
 
    }
}