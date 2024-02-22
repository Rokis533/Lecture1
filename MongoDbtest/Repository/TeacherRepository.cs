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
    internal class TeacherRepository : ITeacherRepository
    {
        private readonly IMongoCollection<Teacher> _teachers;
        public TeacherRepository()
        {
            const string connectionUri = "mongodb+srv://admin:admin@cluster0.6jtgdut.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            var client = new MongoClient(settings);

            var database = client.GetDatabase("school");
            _teachers = database.GetCollection<Teacher>("teachers");
        }
        public void CreateTeacher(Teacher teacher)
        {
            _teachers.InsertOne(teacher);
        }
        public List<Teacher> GetAllTeachers()
        {
            return _teachers.Find(teacher => true).ToList();
        }
        public Teacher GetTeacherById(string id)
        {
            return _teachers.Find<Teacher>(teacher => teacher.Id == id).FirstOrDefault();
        }
        public Teacher GetTeacherByName(string name)
        {
            return _teachers.Find<Teacher>(teacher => teacher.Name == name).FirstOrDefault();
        }
        public void UpdateTeacher(string id, Teacher teacherIn)
        {
            _teachers.ReplaceOne(teacher => teacher.Id == id, teacherIn);
        }
        public void DeleteTeacher(string id)
        {
            _teachers.DeleteOne(teacher => teacher.Id == id);
        }
        public void DeleteAllTeachers()
        {
            _teachers.DeleteMany(teacher => true);
        }

    }
}
