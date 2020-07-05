using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKBookClub.Models
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> AllGenres { get; }
    }
}
