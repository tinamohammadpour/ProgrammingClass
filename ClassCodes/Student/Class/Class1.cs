using Student.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Student.Class
{
    public class Student:IStudentService
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }

        public string FullName() => $"{FirstName} {LastName}";

        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById()
        {
            throw new NotImplementedException();
        }

        public void DisplayAll()
        {
            throw new NotImplementedException();
        }


        public void UpdateById()
        {
            throw new NotImplementedException();
        }
    }
}
