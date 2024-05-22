using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Course.Interfaces;
namespace Pattern_Course.Entity
{

    public class Course : IStudentInformation
    {
        public string CourseName { get; }
        private List<Student> students = new List<Student>();
        private IStudentInformation studentInformation;

        public Course(string courseName, IStudentInformation studentInformation)
        {
            CourseName = courseName;
            this.studentInformation = studentInformation;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine($"{student.Name} добавлен в курс {CourseName}");
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
            Console.WriteLine($"{student.Name} удален из курса {CourseName}");
        }

        public void NotifyStudents(string message)
        {
            Console.WriteLine($"Уведомление для студентов курса {CourseName}: {message}");
            foreach (var student in students)
            {
                studentInformation.DisplayInformation(student);
                student.Update(message);
            }
        }

        public void NotifyStudents(Student student, string message)
        {
            Console.WriteLine($"Уведомление для студента {student.Name}: {message}");
            studentInformation.DisplayInformation(student);
            student.Update(message);
        }



        public void DisplayStudentInformation(Student student)
        {
            studentInformation.DisplayInformation(student);
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        // Реализация метода DisplayInformation для IStudentInformation
        public void DisplayInformation(Student student)
        {
            studentInformation.DisplayInformation(student);
        }
    }
}
