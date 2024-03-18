using IntegrationTestableProject;
using IntegrationTestableProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests
{
    [TestClass]
    public class TopToBottom
    {
        private IBookRepository _bookRepository;

        [TestInitialize]
        public void Setup()
        {
            _bookRepository = new BookRepositoryStub();
        }

        [TestMethod]
        public void GetBook_GetBook_GetsBook()
        {
            var book = _bookRepository.GetBook(1);
            Assert.IsNotNull(book);
        }
    }
}
