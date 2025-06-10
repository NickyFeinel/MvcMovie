using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Linq;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "La noche del terror",
                Genre = "Terror",
                Price = 1,
                ReleaseDate = DateTime.Now
            },
            new Movie
            {
                Id = 2,
                Title = "La noche del terror II",
                Genre = "Terror",
                Price = 5,
                ReleaseDate = DateTime.Now
            }
        };

        // GET: Movies
        public IActionResult Index()
        {
            return View(_movies);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movie.Id = _movies.Count > 0 ? _movies.Max(m => m.Id) + 1 : 1;
                _movies.Add(movie);
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
                return NotFound();

            return View(movie);
        }
    }
}
