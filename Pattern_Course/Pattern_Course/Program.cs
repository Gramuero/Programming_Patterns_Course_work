using System;
using System.Collections.Generic;
using Pattern_Course.Entity;
using Pattern_Course.Interfaces;

class Program
{
    static void Main()
    {
        // Использование Singleton
        Course csharpCourse = CourseSingleton.Instance;

        // Взаимодействие со студентами
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить студента");
            Console.WriteLine("2. Удалить студента");
            Console.WriteLine("3. Послать уведомление всем студентам");
            Console.WriteLine("4. Послать уведомление конкретному студенту");
            Console.WriteLine("5. Выйти");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите имя студента:");
                    string newStudentName = Console.ReadLine();
                    Student newStudent = new Student(newStudentName);
                    csharpCourse.AddStudent(newStudent);
                    break;
                case 2:
                    Console.WriteLine("Выберите студента для удаления:");
                    List<Student> students = csharpCourse.GetStudents();
                    for (int i = 0; i < students.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {students[i].Name}");
                    }
                    int removeChoice = int.Parse(Console.ReadLine());
                    if (removeChoice > 0 && removeChoice <= students.Count)
                    {
                        csharpCourse.RemoveStudent(students[removeChoice - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите уведомление:");
                    string notification = Console.ReadLine();
                    csharpCourse.NotifyStudents(notification);
                    break;
                case 4:
                    Console.WriteLine("Выберите студента для уведомления:");
                    List<Student> studentsForNotification = csharpCourse.GetStudents();
                    for (int i = 0; i < studentsForNotification.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {studentsForNotification[i].Name}");
                    }
                    int notifyChoice = int.Parse(Console.ReadLine());
                    if (notifyChoice > 0 && notifyChoice <= studentsForNotification.Count)
                    {
                        Console.WriteLine("Введите уведомление:");
                        string individualNotification = Console.ReadLine();
                        csharpCourse.NotifyStudents(studentsForNotification[notifyChoice - 1], individualNotification);
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор.");
                    }
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }
}
