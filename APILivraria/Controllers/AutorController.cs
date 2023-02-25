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
        public async Task<ActionResult> CreateLivro(Autor autor)
        {
            await _contextAutor.Autores.AddAsync(autor);

            await _contextAutor.SaveChangesAsync();

            return Ok(autor);
        }
    }
}