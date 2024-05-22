using Pattern_Course.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Course.Entity
{
    // Паттерн Singleton для создания единственного экземпляра курса
    public class CourseSingleton
    {
        private static Course instance;

        private CourseSingleton() { }

        public static Course Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Course("Программирование на C#", new StudentInformation());
                }
                return instance;
            }
        }
    }
}
