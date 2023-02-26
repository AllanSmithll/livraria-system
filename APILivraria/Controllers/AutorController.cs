using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APILivraria.Data;
using APILivraria.Models;
using Microsoft.EntityFrameworkCore;

namespace APILivraria.Controllers
{
    [Route("api/[controllers]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly MainContext _contextAutor;
        public AutorController(MainContext contexto)
        {
            _contextAutor = contexto;
        }

        [HttpGet]
        [Route("/authors")]
        public async Task<ActionResult> GetLAutores()
        {
            return Ok(await _contextAutor.Autores.ToListAsync());
        }

        [HttpPost]
        [Route("/authors")]
        public async Task<ActionResult> CreateAutor(Autor autor)
        {
            await _contextAutor.Autores.AddAsync(autor);

            await _contextAutor.SaveChangesAsync();

            return Ok(autor);
        }

        [HttpPut]
        [Route("/authors")]
        public async Task<ActionResult> UpdateAutor(Autor autor) {
            var dbAutor = await _contextAutor.Autores.FindAsync(autor.IdAutor);

            if (dbAutor == null) {
                return NotFound();
            }

            dbAutor.Obras = autor.Obras;

            await _contextAutor.SaveChangesAsync();

            return Ok(new
            {
                data = autor,
                sucess = true,
                message = "Autor atualizado com sucesso!"
            }
            );
        }

        [HttpDelete]
        [Route("/authors")]
        public async Task<ActionResult> DeleteAutor(Guid IdAutor)
        {
            var dbAutor = await _contextAutor.Autores.FindAsync();

            if (dbAutor == null)
                return NotFound();
            
            _contextAutor.Autores.Remove(dbAutor);

            await _contextAutor.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = ""
            });
    }
}