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
            return Ok( await _context.Livros.ToListAsync());
        }

        [HttpPost]
        [Route("/books")]
        public async Task<ActionResult> CreateLivro(Livro livro)
        {
            await _context.Livros.AddAsync(livro);

            await _context.SaveChangesAsync();

            return Ok(livro);
        }

        [HttpPut]
        [Route("/books")]
        public async Task<ActionResult> UpdateLivro(Livro livro) {
            var dbLivro = await _context.Livros.FindAsync(livro.Isbn);

            if (dbLivro == null) {
                return NotFound();
            }

            dbLivro.Titulo = livro.Titulo;
            dbLivro.Resumo = livro.Resumo;
            dbLivro.QuantPaginas = livro.QuantPaginas;
            dbLivro.Genero = livro.Genero;
            dbLivro.NomeAutor = livro.NomeAutor;
            dbLivro.NomeEditora = livro.NomeEditora;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                data = livro,
                sucess = true,
                message = "Livro atualizado com sucesso!"
            }
            );
        }

        [HttpDelete]
        [Route("/books")]
        public async Task<ActionResult> DeleteLivro(Guid Isbn)
        {
            var dbLivro = await _context.Livros.FindAsync(Isbn);

            if (dbLivro == null)
                return NotFound();
            
            _context.Livros.Remove(dbLivro);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = ""
            });
        }
    }
}