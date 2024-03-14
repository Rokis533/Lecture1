using ManyToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany
{
    internal class Program
    {
        private static readonly CourseContext db = new CourseContext();

        static void Main(string[] args)
        {

            //Author author = db.Authors.FirstOrDefault(x => x.Name == "Rokas");

            //Book book = db.Books.FirstOrDefault(x => x.Title == "Show");

            //Author author1 = new Author() { Name = "Rokas" };

            //book.Authors.Add(author);
            //db.SaveChanges();
            //book.Authors.Add(author1);

            //db.SaveChanges();

            Author author1 = new Author() { Name = "Rokas" };
            Author author2 = new Author() { Name = "John" };
            Author author3 = new Author() { Name = "Rick" };
            Author author4 = new Author() { Name = "Morty" };

            Book book1 = new Book() { Title = "Show", Authors = new List<Author> { author3, author4 } };
            Book book2 = new Book() { Title = "Simpsons", Authors = new List<Author> { author1, author4, author3 } };
            Book book3 = new Book() { Title = "C# for dummies", Authors = new List<Author> { author2, author4 } };
            Book book4 = new Book() { Title = "Facebook", Authors = new List<Author> { author1 } };

            //db.Books.Add(book1);
            //db.SaveChanges();
            //db.Books.Add(book2);
            //db.SaveChanges();
            //db.Books.Add(book3);
            //db.SaveChanges();
            //db.Books.Add(book4);
            //db.SaveChanges();

            AddBook(book1);
            AddBook(book2);
            AddBook(book3);
            AddBook(book4);



        }


        public static void AddBook(Book book)
        {
            using (var db = new CourseContext())
            {

                //for (int i = 0; i < book.Authors.Count(); i++)
                //{
                //    Author author = db.Authors.FirstOrDefault(x => x.Name == book.Authors[i].Name);
                //    if (author is not null)
                //    {
                //        book.Authors[i] = author;
                //    }
                //}

                foreach (var item in book.Authors)
                {
                    if (item.Id == Guid.Empty)
                    {
                        db.Authors.Attach(item);//this is already in database
                        db.Authors.Add(item);
                    }
                }
                var students = db.Books.Add(book);
                db.SaveChanges();
            }
        }

        public static List<Student> GetStudents()
        {
            using (var db = new CourseContext())
            {
                var students = db.Students.ToList();
                return students;
            }
        }
        public static List<Course> GetCourses()
        {
            using (var db = new CourseContext())
            {
                var courses = db.Courses.Include(x => x.CourseStudents).ToList();
                return courses;
            }
        }



        public static void Seed()
        {
            using (var db = new CourseContext())
            {

                var cSharpCourse = db.Courses.FirstOrDefault(x => x.Title == "C#");
                var phpCourse = db.Courses.FirstOrDefault(x => x.Title == "PHP");



                db.Students.AddRange(new List<Student>()
                {
                     new Student()
                    {
                        Name = "Thomas",
                        StudentCourses = new List<Course> { phpCourse, cSharpCourse }
                    },
                    new Student()
                    {
                        Name = "John",
                        StudentCourses = new List<Course> { cSharpCourse }
                    },
                     new Student()
                    {
                        Name = "Linas",
                        StudentCourses = new List<Course> { phpCourse }
                    },
                   new Student()
                    {
                        Name = "Emilis",
                        StudentCourses = new List<Course> { phpCourse }
                    },
                });

                db.SaveChanges();
            }
        }
    }
}
