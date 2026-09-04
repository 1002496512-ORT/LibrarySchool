using Tests.DTO;
using System.Collections.Generic;
namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("Insert Age");
            int age = int.Parse(Console.ReadLine());
            Student student = new Student
            {
                Age = age,
                Id = "123456789",
                Name = "Alex"
            };
            students.Add(student);
            students.Add(
                new Student
                {
                    Age = 16,
                    Id = "23543654",
                    Name = "Roni"
                }
            );

            foreach(Student st in students)
            {
                Console.WriteLine(st.Name);
            }

            Console.ReadLine();
            
        }
    }
}
