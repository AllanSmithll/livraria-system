using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APILivraria.Data;
using APILivraria.Models;
using Microsoft.EntityFrameworkCore;

namespace APILivraria.Controllers
{
    [Route("api/[controllers]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly MainContext _context;
        public LivroController(MainContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/books")]
        public async Task<ActionResult> GetLivros()
        {
            return Ok(await _context.Livros.ToListAsync());
        }

        [HttpPost]
        [Route("/books")]
        public async Task<ActionResult> CreateLivro(Livro livro)
        {
            await _context.Livros.AddAsync(livro);

            await _context.SaveChangesAsync();

            return Ok(livro);
        }
    }
}