using ManyToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = GetCourses();

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Title}: ");



                foreach (var student in course.CourseStudents)
                {
                    Console.WriteLine($"    {student.Name}: ");
                }
                Console.WriteLine($"-----------------------------");
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
