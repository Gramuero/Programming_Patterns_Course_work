using Pattern_Course.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Course.Entity
{
    // Модель (Model) для паттерна MVC
    public class CourseModel
    {
        public string CourseName { get; }
        private List<Student> students = new List<Student>();
        private List<IObserver> observers = new List<IObserver>();

        public CourseModel(string courseName)
        {
            CourseName = courseName;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            NotifyObservers($"{student.Name} добавлен в курс {CourseName}");
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
            NotifyObservers($"{student.Name} удален из курса {CourseName}");
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void NotifyStudents(string message)
        {
            foreach (var student in students)
            {
                student.Update(message);
            }
        }
        // Добавление Observer
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        // Уведомление всех Observer
        private void NotifyObservers(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}
