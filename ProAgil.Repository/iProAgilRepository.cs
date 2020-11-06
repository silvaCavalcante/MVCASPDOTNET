using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface iProAgilRepository
    {
        //GERAL
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;   
         void Delete<T>(T entity) where T : class; 
        Task<bool> SaveChangesAsync();

        //EVENTOS
        Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includPalestrantes);
        Task<Evento[]> GetAllEventoAsync(bool includPalestrantes);
        Task<Evento> GetEventoAsyncById(int EventoId, bool includPalestrantes);

        //PALESTRANTE
        Task<Palestrante[]> GetAllPalestranteAsyncByName(string nome, bool includEventos);
        Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool includEventos);
    }
}