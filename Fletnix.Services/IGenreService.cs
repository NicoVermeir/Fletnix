using Fletnix.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fletnix.Services
{
    public interface IGenreService
    {
        IList<Genre> GetGenres();

        void SaveGenre(Genre item);
    }
}
