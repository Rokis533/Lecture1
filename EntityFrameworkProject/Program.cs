using EntityFrameworkProject.Database;
using EntityFrameworkProject.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BookContext())
            {
                var transaction = db.Database.BeginTransaction();

                try
                {
                    Book book = new Book()
                    {
                        Id = Guid.NewGuid(),
                        Name = "999M",
                    };

                    db.Books.Add(book);
                    db.SaveChanges();

                    transaction.CreateSavepoint("CreateBook");


                    for (int i = 0; i < 300; i++)
                    {
                        Page page = new Page(i, $"Content-{i}");
                        page.Book = book;
                        db.Pages.Add(page);
                        db.SaveChanges();
                    }




                    Book book2 = db.Books.FirstOrDefault(x => x.Name == "100M Dollar Leads");

                    Console.WriteLine(book2);

                    foreach (var item in book2.Pages)
                    {
                        Console.WriteLine(item.Content);
                    }

                    throw new Exception("Test");
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    transaction.RollbackToSavepoint("CreateBook");
                    transaction.Commit();
                    Console.WriteLine("-----------");
                    //transaction.Rollback();
                }
            }
        }
    }
}
