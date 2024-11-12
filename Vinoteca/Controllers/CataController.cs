using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Vinoteca.Data;
using Vinoteca.Data.Entities;
using Vinoteca.Models;
using Vinoteca.Services;

namespace Vinoteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CataController : ControllerBase
    {
        private readonly CataService _cataService;
        private readonly VinotecaContext _context;

        public CataController(CataService cataService, VinotecaContext context)
        {
            _cataService = cataService;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCata([FromBody] CataCreateDto cataDto)
        {
            var vinos = await _context.Wines
                                      .Where(w => cataDto.Wines.Contains(w.Id))
                                      .ToListAsync();

            var cata = new Cata
            {
                Fecha = cataDto.Fecha,
                Nombre = cataDto.Nombre,
                Wines = vinos
            };

            var createdCata = await _cataService.CreateCataAsync(cata);
            return CreatedAtAction(nameof(GetCataById), new { id = createdCata.Id }, createdCata);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCataById(int id)
        {
            var cata = await _context.Catas.Include(c => c.Wines).FirstOrDefaultAsync(c => c.Id == id);
            if (cata == null) return NotFound();
            return Ok(cata);
        }

        [HttpGet("upcoming")]
        public async Task<IActionResult> GetUpcomingCatas()
        {
            var upcomingCatas = await _context.Catas
                                              .Where(c => c.Fecha > DateTime.Now)
                                              .Include(c => c.Wines)
                                              .ToListAsync();
            return Ok(upcomingCatas);
        }

        [HttpPatch("{id}/invitados")]
        public async Task<IActionResult> UpdateInvitados(int id, [FromBody] CataUpdateInvitadosDto invitadosDto)
        {
            var cata = await _context.Catas.FindAsync(id);
            if (cata == null) return NotFound();

            cata.Invitados.AddRange(invitadosDto.Invitados);
            await _context.SaveChangesAsync();

            return Ok(cata);
        }

    }

}
