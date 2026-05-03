using Microsoft.AspNetCore.Mvc;
using TP_MODUL10_103022400053;

namespace TP_MODUL10_103022400053.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : Controller
    {
        private static readonly List<Film> films = new List<Film>
        {
            new Film
            {
                Judul = "Inception",
                Sutradara = "Christopher Nolan",
                Tahun = "2010",
                Genre = "Sci-Fi",
                Rating = "9.0"
            },
            new Film
            {
                Judul = "Interstellar",
                Sutradara = "Christopher Nolan",
                Tahun = "2014",
                Genre = "Sci-Fi",
                Rating = "8.7"
            },
            new Film
            {
                Judul = "Parasite",
                Sutradara = "Bong Joon-ho",
                Tahun = "2019",
                Genre = "Thriller",
                Rating = "8.6"
            }
        };
        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return films;
        }

        [HttpGet("{id}")]
        public Film Get(int id)
        {
            return films[id];
        }

        [HttpPost]
        public void Post([FromBody] Film filmBaru)
        {
            films.Add(filmBaru);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            films.RemoveAt(id);
        }
    }

}