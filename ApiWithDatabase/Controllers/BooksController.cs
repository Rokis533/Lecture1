using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiWithDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILogger<WeatherForecastController> logger;

        public BooksController(IBookRepository bookRepository, ILogger<WeatherForecastController> logger)
        {
            this.bookRepository = bookRepository;
            this.logger = logger;
        }


        // GET: api/Books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_bookRepository.GetBooks());
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(Guid id)
        {
            var book = _bookRepository.Get(id, null, null, DateTime.Now);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutBook(Guid id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            try
            {
                _bookRepository.Update(book);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_bookRepository.BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Book> PostBook(Book book)
        {

            book = _bookRepository.Add(book);
            return CreatedAtAction("GetBook", new { id = book.Id }, book);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(Guid id)
        {
            if (!_bookRepository.BookExists(id))
            {
                return NotFound();
            }

            _bookRepository.Delete(id);

            return NoContent();
        }


    }
}
