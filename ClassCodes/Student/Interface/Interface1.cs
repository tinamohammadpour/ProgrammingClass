using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Interface
{
    public interface IStudentService
    {
        void Add(Student.Class.Student student);
        void DeleteById();
        void UpdateById();
        void DeleteAll();
        void DisplayAll();
    }
}
