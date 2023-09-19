using AutoMapperTest.Models;

namespace AutoMapperTest.Data
{
    public class BookStore
    {
        public static List<book> booksList = new List<book>()
        {
            new book{BookId = 0,Title="Test Title 1",Author="Test Title 1", Summary="Summary 1",Price= 100.5},
            new book{BookId = 1,Title="Test Title 2",Author="Test Title 2", Summary="Summary 2",Price= 75.0},
            new book{BookId = 2,Title="Test Title 3",Author="Test Title 3", Summary="Summary 3",Price= 0},
        };
}
}
