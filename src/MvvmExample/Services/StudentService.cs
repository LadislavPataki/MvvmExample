using System.Collections.Generic;
using MvvmExample.Model;

namespace MvvmExample.Services
{
    public class StudentService : IStudentService
    {
        private List<Student> studentsRepository = new List<Student>
        {
            new Student {Name = "John Snow", Email = "John.Snow@soaf.com"},
            new Student {Name = "Tyrion Lannister", Email = "Tyrion.Lannister@soaf.com"},
            new Student {Name = "Arya Stark", Email = "Arya.Stark@soaf.com"},
            new Student {Name = "Victarion.Greyjoy", Email = "Victarion.Greyjoy@soaf.com"},
        };

        public IEnumerable<Student> GetStudents()
        {
            return studentsRepository;
        }

        public void SaveStudents(IEnumerable<Student> students)
        {
            studentsRepository = new List<Student>(students);
        }
    }
}