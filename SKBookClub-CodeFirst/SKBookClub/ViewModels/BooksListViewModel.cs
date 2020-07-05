using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SKBookClub.Models;

namespace SKBookClub.ViewModels
{
    public class BooksListViewModel
    { 
         public IEnumerable<Book> Books { get; set; }
         public string CurrentGenre { get; set; }
     }
}
