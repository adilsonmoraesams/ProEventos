using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Contratos
{
    public interface IPalestranteService
    {
        Task<Evento> AddEventos(Evento model);
        Task<Evento> Updateventos(int eventoId, Evento model);
        Task<bool> DeleteEventos(int eventoId);
        
        // Listas
        Task<Palestrante[]>  GetAllPalestrantesByNomeAsync(string Nome, bool includeEventos = false);
        Task<Palestrante[]>  GetAllPalestrantesAsync(bool includeEventos);
        Task<Palestrante>  GetAllPalestrantesByIdAsync(int PalestranteId, bool includeEventos = false);
    }
}