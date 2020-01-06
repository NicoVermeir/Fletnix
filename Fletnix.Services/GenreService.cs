using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Fletnix.Model;
using Fletnix.Repositories;

namespace Fletnix.Services
{
    class GenreService : IGenreService
    {
        private readonly IRepository<Genre> _genreRepository;

        public GenreService(IRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
        }
        public Task<IList<Genre>> GetGenres()
        {
            return _genreRepository.Get();
        }

        public void SaveGenre(Genre item)
        {
            _genreRepository.Create(item);
        }
    }
}
