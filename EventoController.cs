using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizadordeevntosMirelys.DataB;
using OrganizadordeevntosMirelys.Models;

namespace OrganizadordeevntosMirelys.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class EventosController : ControllerBase
        {
            private readonly AppDbContext _context;
            public EventosController(AppDbContext context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<Evento>>> GetEventos()
            {
                return await _context.Evento
                    .Include(e => e.Invitados)
                    .Include(e => e.Tareas)
                    .Include(e => e.Presupuesto)
                    .Include(e => e.Cronograma)
                    .ToListAsync();
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<Evento>> GetEvento(int id)
            {
                var evento = await _context.Evento
                    .Include(e => e.Invitados)
                    .Include(e => e.Tareas)
                    .Include(e => e.Presupuesto)
                    .Include(e => e.Cronograma)
                    .FirstOrDefaultAsync(e => e.Id == id);

                return evento == null ? NotFound() : Ok(evento);
            }

            [HttpPost]
            public async Task<ActionResult<Evento>> PostEvento(Evento evento)
            {
                _context.Evento.Add(evento);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetEvento), new { id = evento.Id }, evento);
            }

            [HttpPut("{id}")]
            public async Task<IActionResult> PutEvento(int id, Evento evento)
            {
                if (id != evento.Id)
                    return BadRequest();

                _context.Entry(evento).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return NoContent();
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteEvento(int id)
            {
                var evento = await _context.Evento.FindAsync(id);
                if (evento == null)
                    return NotFound();

                _context.Evento.Remove(evento);
                await _context.SaveChangesAsync();
                return NoContent();
            }
        }

    }

