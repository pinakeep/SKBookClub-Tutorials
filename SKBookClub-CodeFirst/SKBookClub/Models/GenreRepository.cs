using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKBookClub.Models
{
    public class GenreRepository : IGenreRepository
    {
        private readonly AppDbContext _appDbContext;

        public GenreRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Genre> AllGenres => _appDbContext.Genres;

    }
}
