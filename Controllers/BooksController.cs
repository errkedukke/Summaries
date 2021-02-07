using Microsoft.AspNetCore.Mvc;
using Summaries.Data;

namespace Summaries.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private IBookService _service;

        public BooksController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_service.GetAllBooks());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetBook(int id)
        {
            var book = _service.GetAllBooks().Find(x => x.Id == id);
            
            if(book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public IActionResult PostBook([FromBody] Book book)
        {
            _service.AddBook(book);
            return Ok();
        }
        
        [HttpPut("{id:int}")]
        public IActionResult PutBook(int id, [FromBody] Book book)
        {
            _service.UpdateBook(id, book);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteBook(int id)
        {
            _service.DeleteBook(id);
            return Ok();
        }
    }
}