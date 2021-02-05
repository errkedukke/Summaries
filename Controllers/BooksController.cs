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

        // GET
        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_service.GetAllBooks());
        }

        // GET ONE

        // POST
        //[HttpPost("AddBook")]
        [HttpPost]
        public IActionResult PostBook([FromBody] Book book)
        {
            _service.AddBook(book);
            return Ok("Added");
        }
        // PUT

        // DELETE
    }
}