using HomoForKids.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontolApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var studentRepo = new StudentRepositories();
            var listStudent = studentRepo.PrintStudents();

            foreach (var student in listStudent)
            {
                Console.WriteLine(student.Name + " " +student.Nis + " "+ student.Email);
            }

            Console.ReadKey();
        }
    }
}
