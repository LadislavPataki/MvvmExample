using System.Collections.Generic;
using MvvmExample.Model;

namespace MvvmExample.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        void SaveStudents(IEnumerable<Student> students);
    }
}