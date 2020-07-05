using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SKBookClub.Models;
using SKBookClub.ViewModels;

namespace SKBookClub.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IGenreRepository _genreRepository;

        public BookController(IBookRepository bookRepository, IGenreRepository genreRepository)
        {
            _bookRepository = bookRepository;
            _genreRepository = genreRepository;
        }

        // GET: /<controller>/
        public IActionResult List()
        {
            
            //return View(_bookRepository.AllBooks);
            BooksListViewModel booksListViewModel = new BooksListViewModel();
            booksListViewModel.Books = _bookRepository.AllBooks;

            booksListViewModel.CurrentGenre = "Horror";
            return View(booksListViewModel);
        }
    }
}
