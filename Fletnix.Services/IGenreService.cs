using Fletnix.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fletnix.Services
{
    public interface IGenreService
    {
        Task<IList<Genre>> GetGenres();

        void SaveGenre(Genre item);
    }
}
