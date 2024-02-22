using MongoDbtest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbtest.Repository.Interfaces
{
    internal interface IStudentRepository
    {
        public void CreateStudent(Student student);
        public List<Student> GetAllStudents();
        public Student GetStudentById(string id);
        public void UpdateStudent(string id, Student studentIn);
        public void DeleteStudent(string id);
        public void DeleteAllStudents();



    }
}
