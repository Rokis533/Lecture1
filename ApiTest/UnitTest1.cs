using ApiWithDatabase;
using ApiWithDatabase.Controllers;
using AutoFixture;
using AutoFixture.Xunit2;
using Moq;

namespace ApiTest
{
    public class UnitTest1
    {

        [Theory, CustomData]
        public void Test1(Book book)
        {

            var repoMock = new Mock<IBookRepository>();

            var sut = new BooksController(repoMock.Object);
            repoMock.Setup(x => x.Get(It.IsAny<Guid>(), null, null, DateTime.Now)).Returns(book);

            var testResponse = sut.GetBook(It.IsAny<Guid>());

            Assert.Equal(testResponse.Value, book);
        }
    }
}