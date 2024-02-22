using MongoDbtest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbtest.Repository.Interfaces
{
    internal interface ITeacherRepository
    {
        public void CreateTeacher(Teacher Teacher);
        public List<Teacher> GetAllTeachers();
        public Teacher GetTeacherById(string id);
        public Teacher GetTeacherByName(string name);
        public void UpdateTeacher(string id, Teacher TeacherIn);
        public void DeleteTeacher(string id);
        public void DeleteAllTeachers();



    }
}
