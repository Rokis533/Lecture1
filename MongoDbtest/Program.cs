using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbtest.Models;
using MongoDbtest.Repository;
using MongoDbtest.Repository.Interfaces;

namespace MongoDbtest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository studentRepository = new StudentRepository();
            ITeacherRepository teacherRepository = new TeacherRepository();

            Teacher teacher = teacherRepository.GetTeacherByName("Rokas");

            Student student = new Student() { Name = "John", Grade = 12, Age = 16, Teacher = teacher };

            studentRepository.CreateStudent(student);



        }

    }
}
