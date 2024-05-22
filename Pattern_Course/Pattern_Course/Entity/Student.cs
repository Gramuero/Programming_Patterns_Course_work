using Pattern_Course.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Course.Entity
{
    // Класс студента для паттерна Observer
    public class Student : IObserver
    {
        public string Name { get; }

        public Student(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"Студент {Name} получил уведомление: {message}");
        }
    }
}
