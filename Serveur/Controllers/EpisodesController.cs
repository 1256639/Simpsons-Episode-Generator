using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpsonsEpisodeGenerator.Data;
using SimpsonsEpisodeGenerator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpsonsEpisodeGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodesController : ControllerBase
    {
        private readonly SimpsonsEpisodeGeneratorContext _context;

        public EpisodesController(SimpsonsEpisodeGeneratorContext context)
        {
            _context = context;
        }

        // GET: api/episodes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Episode>>> GetEpisodes()
        {
            return await _context.Episodes.ToListAsync();
        }

        // GET: api/episodes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Episode>> GetEpisode(int id)
        {
            var episode = await _context.Episodes.FindAsync(id);

            if (episode == null)
            {
                return NotFound();
            }

            return episode;
        }

        // GET: api/episodes/random
        [HttpGet("random")]
        public async Task<ActionResult<Episode>> GetRandomEpisode()
        {
            var count = await _context.Episodes.CountAsync();
            if (count == 0)
                return NotFound();
            var random = new Random();
            int skip = random.Next(count);
            var episode = await _context.Episodes.Skip(skip).FirstOrDefaultAsync();
            return episode!;
        }
    }
}