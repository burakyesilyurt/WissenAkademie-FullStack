using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSample.Model;

namespace WebApiSample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private List<Book> BookList = new List<Book>()
        {
            new Book()
            {
                BookID = 1,
                Title = "Suç ve Ceza",
                PageCount=800,
                PublishDate = new DateTime(1994,2,25),
                ISBN = Guid.NewGuid().ToString()
            },
            new Book()
            {
                BookID = 2,
                Title = "Savaş ve Barış",
                PageCount=600,
                PublishDate = new DateTime(1998,12,10),
                ISBN = Guid.NewGuid().ToString()
            },
            new Book()
            {
                BookID = 3,
                Title = "Yer Altından Notlar",
                PageCount=800,
                PublishDate = new DateTime(2001,5,12),
                ISBN = Guid.NewGuid().ToString()
            },
            new Book()
            {
                BookID = 4,
                Title = "Dönüşüm",
                PageCount=750,
                PublishDate = new DateTime(2005,8,17),
                ISBN = Guid.NewGuid().ToString()
            }
        };

        [HttpGet]
        //api/Book/Books
        public List<Book> Books()
        {
            var bookList = BookList.OrderBy(x => x.PublishDate).ToList();
            return bookList;
        }

        [HttpGet("{BookId}")]
        public Book GetBookById(int BookId)
        {
            var book = BookList.SingleOrDefault(x => x.BookID == BookId);
            return book;
        }

        [HttpGet("{BookId}")]
        [ActionName("GetBookIDStr")]
        public Book GetBookById(string BookId)
        {
            var book = BookList.SingleOrDefault(x => x.BookID == int.Parse(BookId));
            return book;
        }
    }
}
