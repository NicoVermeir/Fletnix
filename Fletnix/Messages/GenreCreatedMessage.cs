using Fletnix.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fletnix.Messages
{
    public class GenreCreatedMessage
    {
        public Genre NewGenre { get; set; }
        public GenreCreatedMessage(Genre newGenre)
        {
            NewGenre = newGenre;
        }
    }
}
