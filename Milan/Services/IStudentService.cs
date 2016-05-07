using System.Collections.Generic;
using Milan.Model;

namespace Milan.ViewModel
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        void SaveStudents(IEnumerable<Student> students);
    }
}