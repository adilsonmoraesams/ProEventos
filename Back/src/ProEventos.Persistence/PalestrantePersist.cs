using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.Contratos;
using ProEventos.Persistence.Contextos;

namespace ProEventos.Persistence
{
    public class PalestrantePersist : IPalestrantePersist
    {

        private readonly ProEventosContext _context;

        public PalestrantePersist(ProEventosContext context)
        {
            this._context = context;
        }
  
        public async Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false)
        {  
            IQueryable<Palestrante> query =  _context.Palestrantes.Include(e => e.RedesSociais);

            if (includeEventos)
            {
                        query = query.Include(e => e.PalestrantesEventos).ThenInclude(pe => pe.Evento);
            }

            query = query.OrderBy(p => p.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string Nome, bool includeEventos)
        {
            IQueryable<Palestrante> query = _context.Palestrantes.Include(e => e.RedesSociais);

            if (includeEventos)
            {
                query = query.Include(e => e.PalestrantesEventos).ThenInclude(pe => pe.Evento);
            }

            query = query.Where(p => p.Nome.ToLower().Contains(Nome));

            return await query.ToArrayAsync();
        }
 
        public async Task<Palestrante> GetAllPalestrantesByIdAsync(int PalestranteId, bool includeEventos)
        {
            IQueryable<Palestrante> query =  _context.Palestrantes.Include(e => e.RedesSociais);

            if (includeEventos)
            {
                query = query.Include(e => e.PalestrantesEventos).ThenInclude(pe => pe.Evento);
            }

            query = query.OrderBy(p => p.Id)
                        .Where(p => p.Id == PalestranteId);

            return await query.FirstOrDefaultAsync();
        }



    }
}