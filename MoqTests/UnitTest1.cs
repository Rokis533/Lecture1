using Moq;
using IntegrationTestableProject;
using IntegrationTestableProject.Repository;
using IntegrationTestableProject.Models;
using Microsoft.EntityFrameworkCore;

namespace MoqTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var data = new List<Book>
            {
                 new Book { Id = 1, Author = "Test", Title = "Test" }
            }.AsQueryable();


            var mockSet = new Mock<DbSet<Book>>();
            var mockContext = new Mock<BookStoreContext>(new DbContextOptions<BookStoreContext>());


            mockSet.As<IQueryable<Book>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Book>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Book>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Book>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());


            mockContext.Setup(s => s.Books).Returns(mockSet.Object);

            var bookRepository = new BookRepository(mockContext.Object);



            var result = bookRepository.GetBook(1);

            Assert.AreEqual(
                data.ToList().First(),
                result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var mockOfValidation = new Mock<IBookTest>();

            mockOfValidation.Setup(s => s.ValidateEmail("Hellosdasdasd")).Returns(true);

            var validation = mockOfValidation.Object;

            var result = validation.ValidateEmail("Hellosdasdasd");

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void TestMethod3()
        {
            var mockRepo = new Mock<IBookRepository>();

            var book = new Book()
            {
                Id = 1,
                Author = "Test0",
                Title = "some"
            };

            mockRepo.Setup(s => s.GetBook(1))
                .Returns(book);

            var bookRepository = mockRepo.Object;

            var mockbookService = new Mock<BookService>(bookRepository);

            mockbookService.Setup(s => s.GetBookTitle(It.IsAny<Book>())).Returns(book.Title + " test test");

            var bookService = mockbookService.Object;

            var result = bookService.GetBookName(1);

            Assert.AreEqual(book.Title + " test test", result);

        }
    }
}