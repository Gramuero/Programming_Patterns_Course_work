using Pattern_Course.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Course.Interfaces;

namespace Pattern_Course.Entity
{
    // Представление (View) для паттерна MVC

    public class CourseView : IObserver, IStudentInformation
    {
        public void DisplayStudentInformation(Student student)
        {
            Console.WriteLine($"Информация о студенте {student.Name}");
            // Здесь можно добавить другие данные о студенте, если необходимо
        }

        public void DisplayNotification(string courseName, string message)
        {
            Console.WriteLine($"Уведомление для студентов курса {courseName}: {message}");
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Реализация метода Update для Observer
        public void Update(string message)
        {
            DisplayMessage(message);
        }

        // Реализация метода DisplayInformation для IStudentInformation
        public void DisplayInformation(Student student)
        {
            DisplayStudentInformation(student);
        }
    }
}

