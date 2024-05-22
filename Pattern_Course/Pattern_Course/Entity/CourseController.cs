using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Course.Entity
{
    // Контроллер (Controller) для паттерна MVC
    public class CourseController
    {
        private CourseModel model;
        private CourseView view;

        public CourseController(CourseModel model, CourseView view)
        {
            this.model = model;
            this.view = view;
            // Регистрация представления в качестве Observer
            model.AddObserver(view);
        }

        public void AddStudent(string name)
        {
            Student student = new Student(name);
            model.AddStudent(student);
        }

        public void RemoveStudent(Student student)
        {
            model.RemoveStudent(student);
        }

        public void NotifyStudents(string message)
        {
            view.DisplayNotification(model.CourseName, message);
            model.NotifyStudents(message);
        }

        public void DisplayStudentInformation(Student student)
        {
            view.DisplayStudentInformation(student);
        }

        public List<Student> GetStudents()
        {
            return model.GetStudents();
        }
    }
}
