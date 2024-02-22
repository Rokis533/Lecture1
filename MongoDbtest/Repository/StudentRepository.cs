using MongoDB.Driver;
using MongoDbtest.Models;
using MongoDbtest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbtest.Repository
{
    internal class StudentRepository : IStudentRepository
    {
        private readonly IMongoCollection<Student> _students;
        public StudentRepository()
        {
            const string connectionUri = "mongodb+srv://admin:admin@cluster0.6jtgdut.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            var client = new MongoClient(settings);

            var database = client.GetDatabase("school");
            _students = database.GetCollection<Student>("students");
        }
        public void CreateStudent(Student student)
        {
            _students.InsertOne(student);
        }
        public List<Student> GetAllStudents()
        {
            return _students.Find(student => true).ToList();
        }
        public Student GetStudentById(string id)
        {
            return _students.Find<Student>(student => student.Id == id).FirstOrDefault();
        }
        public void UpdateStudent(string id, Student studentIn)
        {
            _students.ReplaceOne(student => student.Id == id, studentIn);
        }
        public void DeleteStudent(string id)
        {
            _students.DeleteOne(student => student.Id == id);
        }
        public void DeleteAllStudents()
        {
            _students.DeleteMany(student => true);
        }

    }
}
