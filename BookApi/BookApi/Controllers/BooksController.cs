using BookApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    //https://localhost:7173/api/books
    [Route("api/[Controller]")] //Controller gets accessed by this route.
    [ApiController] //More Functionality - Server side Errors check
    public class BooksController : ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book{ Id = 1, Author = "Author One", Title = "Book One"},
            new Book{ Id = 2, Author = "Author Two", Title = "Book Two"},
            new Book{ Id = 3, Author = "Author Three", Title = "Book Three"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks() //Ienumerable can return a list or an array. This is refered to as an endpoint. A Get endpoint. 
        {
            return Ok(_books);
        } 
        
    }
}
/*
HTTP Requests and Responses

Requests
GET - To get info from backend
POST - Creating New things or Updating.
PUT - Update Stuff on server
DELETE - Deleting entities

CRUD - Create Read Update Delete. Like twitter - over and over agian
most of the time its these operations.

Responses
Not found - 404
Ok - 200 
Bad Request - 400
Server Error - 500

Headers - Both Requests and Responses can have headers.
They submit additional info for the requests and responses
 */