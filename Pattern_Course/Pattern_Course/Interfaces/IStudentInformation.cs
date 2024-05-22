using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Course.Entity;

namespace Pattern_Course.Interfaces
{
    // Интерфейс для вывода информации о студенте
    public interface IStudentInformation
    {
        void DisplayInformation(Student student);
    }
}
