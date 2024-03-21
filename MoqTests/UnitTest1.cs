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
        private BookStoreContext _context;
        private IBookRepository _bookRepository;

        [TestInitialize]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<BookStoreContext>()
                .UseInMemoryDatabase(databaseName: "TestDB")
                .Options;


            _context = new BookStoreContext(options);
            _bookRepository = new BookRepository(_context);

            _bookRepository.AddBook(new Book() { Id = 1, Author = "John", Title = "No name" });
        }
        [TestCleanup]
        public void CleanUp()
        {
            _context.Database.EnsureDeleted();
        }
        [TestMethod]
        public void TestMethod1()
        {
            var data = new List<Book>
            {
                 new Book { Id = 1, Author = "Test", Title = "Test" },
                 new Book { Id = 2, Author = "2", Title = "Tes121t9999999999" },
                 new Book { Id = 3, Author = "Te21112st", Title = "Test1212212121221" },
            }.AsQueryable();


            var mockSet = new Mock<DbSet<Book>>();
            var mockContext = new Mock<BookStoreContext>(new DbContextOptions<BookStoreContext>());


            mockSet.As<IQueryable<Book>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Book>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Book>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Book>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());


            mockContext.SetupProperty(s => s.Books, mockSet.Object);

            var bookRepository = new BookRepository(mockContext.Object);

            bookRepository.AddBook(new Book { Id = 2, Author = "111", Title = "222" });

            var result = bookRepository.GetAllBooks().ToList();

            Assert.AreEqual(
                data.ToList(),
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
        public void GetBookFromLibrary_SendEmailFails()
        {
            var mockRepo = new Mock<IBookRepository>();
            var mockEmail = new Mock<IEmailService>();


            var book = new Book()
            {
                Id = 1,
                Author = "Test0",
                Title = "some"
            };

            mockEmail.Setup(s => s.SendEmail("Name"))
                .Returns(true);

            mockRepo.Setup(s => s.GetBook(1))
                .Returns(book);

            var bookRepository = mockRepo.Object;
            var emailService = mockEmail.Object;



            var mockbookService = new BookService(bookRepository, emailService, (IGetFromApi)new GetFromApi());

            string result = mockbookService.GetBookFromLibrary(1);


            Assert.AreEqual(string.Empty, result);

        }
        [TestMethod]
        public void GetBookFromLibrary_SendEmailSuccess()
        {
            var mockRepo = new Mock<IBookRepository>();
            var mockEmail = new Mock<IEmailService>();


            var book = new Book()
            {
                Id = 1,
                Author = "Test0",
                Title = "some"
            };

            mockEmail.Setup(s => s.SendEmail("some"))
                .Returns(true);

            mockRepo.Setup(s => s.GetBook(1))
                .Returns(book);

            var bookRepository = mockRepo.Object;
            var emailService = mockEmail.Object;

            var mockbookService = new BookService(bookRepository, emailService, (IGetFromApi)new GetFromApi());

            string result = mockbookService.GetBookFromLibrary(1);


            Assert.AreEqual(book.Title, result);

        }
        [TestMethod]
        public void GetBookFromLibrary_SendEmailSuccess_Database()
        {
            var mockEmail = new Mock<IEmailService>();


            mockEmail.Setup(s => s.SendEmail(It.IsAny<string>()))
                .Returns(true);

            var emailService = mockEmail.Object;

            var mockbookService = new BookService(_bookRepository, emailService, (IGetFromApi)new GetFromApi());

            string result = mockbookService.GetBookFromLibrary(1);


            Assert.AreEqual("No name", result);

        }
        [TestMethod]
        public void GetFromAPI_Gets()
        {
            var mockapi = new Mock<IGetFromApi>();


            mockapi.Setup(s => s.GetData())
                .Returns("                         Book, okk okkook oko k                                    ");

            var api = mockapi.Object;

            var mockbookService = new BookService(_bookRepository, new EmailService(), api);

            string result = mockbookService.GetBooksStringFromInternet();


            Assert.AreEqual("Book, okk okkook oko k", result);

        }
        [TestMethod]
        public void GetsNumbers()
        {
            var mock = new Mock<MyClass>();

            var list = new List<int>()
            {

            };

            mock.SetupProperty(s => s.Numbers, list);


            var myclass = mock.Object;


            var myclass2 = new MyClass2(myclass);
            myclass2.AddNumber(1);
            myclass2.AddNumber(5);


            var result = myclass2.GetNumbers();


            Assert.AreEqual(list, result);

        }
    }
}