using Pattern_Course.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Course.Interfaces;

namespace Pattern_Course.Entity
{
    // Класс, реализующий интерфейс IStudentInformation
    public class StudentInformation : IStudentInformation
    {
        public void DisplayInformation(Student student)
        {
            Console.WriteLine($"Информация о студенте {student.Name}");
            // Здесь можно добавить другие данные о студенте, если необходимо
        }
    }
}
