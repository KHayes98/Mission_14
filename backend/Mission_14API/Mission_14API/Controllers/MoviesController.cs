using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mission_14API.Data;

namespace Mission_14API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieDbContext _context;

        public MoviesController(MovieDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEditedMovies()
        {
            var editedMovies = _context.Movies
                .Where(m => m.Edited)
                .OrderBy(m => m.Title)
                .ToList();

            return Ok(editedMovies);
        }
    }
}
