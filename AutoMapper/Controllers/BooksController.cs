using AutoMapper;
using AutoMapperTest.Data;
using AutoMapperTest.Dtos;
using AutoMapperTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperTest.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]


    public class BooksController : ControllerBase   
    {
        private readonly IMapper _mapper;

        public BooksController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            //var result = BookStore.books.FirstOrDefault(u => u.Id == id);
            //var result = BookStore.booksList.Select(u => new BookDto { Id = u.Id, Title = u.Title, Author = u.Author, Price = u.Price, Summary = u.Summary });
            var result = _mapper.Map<IEnumerable<BookDto>>(BookStore.booksList);

            //return Ok(BookStore.booksList);
            return Ok(result);
        }

        [HttpGet("{id}")]

        public IActionResult GetId(int id)
        {

            var book = BookStore.booksList.SingleOrDefault(m => m.BookId == id);

            //var bookDto = new BookDto
            //{
            //    Id = book.BookId,
            //    Title = book.Title,
            //    Summary = book.Summary,
            //    Price = book.Price,
            //};

            //return Ok(book);
            return Ok(_mapper.Map<BookDto>(book));
        }

        [HttpPost]
        public IActionResult Create( BookDto dto)
        {

            //var book = BookStore.booksList.SingleOrDefault(m => m.BookId == id);
            //return Ok(book);


        
            return Ok(_mapper.Map<book>(dto));
        }

        //[HttpPost]
        //public ActionResult Create<BookDto>([FromBody] BookDto dto)
        //{

        //    dto.Id = BookStore.booksList.OrderByDescending(U => U.BookId).FirstOrDefault().BookId + 1;
        //    BookStore.booksList.Add(dto);
        //    return Ok(_mapper.Map<book>(dto));
        //}

    }
}
