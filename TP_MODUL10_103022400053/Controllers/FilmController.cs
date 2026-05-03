using Microsoft.AspNetCore.Mvc;

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
                judul = "Inception",
                sutradara = "Christopher Nolan",
                tahun = "2010",
                genre = "Sci-Fi",
                rating = "9.0"
            },
            new Film
            {
                judul = "Interstellar",
                sutradara = "Christopher Nolan",
                tahun = "2014",
                genre = "Sci-Fi",
                rating = "8.7"
            },
            new Film
            {
                judul = "Parasite",
                sutradara = "Bong Joon-ho",
                tahun = "2019",
                genre = "Thriller",
                rating = "8.6"
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