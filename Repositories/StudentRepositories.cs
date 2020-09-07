using HomoForKids.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomoForKids.Repositories
{
    public class StudentRepositories
    {
        public List<Student> PrintStudents()
        {
            var studentList = new List<Student>();
            studentList.Add(new Student
            {
                 Nis = 15236,
                 Name = "Rendi",
                 Email = "yosafatrendip@gmail.com"
            });

            studentList.Add(new Student
            {
                Nis = 15237,
                Name = "Jordi",
                Email = "jordi@gmail.com"
            });

            studentList.Add(new Student
            {
                Nis = 15238,
                Name = "Parno",
                Email = "parno@gmail.com"
            });

            studentList.Add(new Student
            {
                Nis = 15239,
                Name = "Ratno",
                Email = "ratno@gmail.com"
            });

            studentList.Add(new Student
            {
                Nis = 15239,
                Name = "Rani",
                Email = "rani@gmail.com"
            });
            return studentList;
        }
    }
}
