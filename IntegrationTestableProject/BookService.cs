using IntegrationTestableProject.Models;
using IntegrationTestableProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTestableProject
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IEmailService _emailService;
        private readonly IGetFromApi _api;

        public BookService(IBookRepository bookRepository, IEmailService emailService, IGetFromApi api)
        {
            _bookRepository = bookRepository;
            _emailService = emailService;
            _api = api;
        }

        public string GetBooksStringFromInternet()
        {
            var str = _api.GetData();
            str = str.Trim();

            //procces the data
            return str;
        }

        public Book GetBook(int id)
        {
            return _bookRepository.GetBook(id);
        }
        public string GetBookFromLibrary(int id)
        {
            var book = GetBook(id);

            if (book == null)
            {
                return string.Empty;
            }
            //notify admin that this book was requested

            bool isEmailSentSuccesfully = _emailService.SendEmail(book.Title);

            if (isEmailSentSuccesfully)
            {
                return book.Title;
            }


            return string.Empty;
            //var title = GetBookTitle(book);


            //var api = new GetFromApi();
            //var data = api.Get("google.com");



        }
        public virtual string GetBookTitle(Book book)
        {
            return book.Title + ".DR";
        }
    }
}
