using System;
using System.Collections.Generic;

namespace Kordamine
{
    public class StudentMain
    {
        public static void Main()
        {
            Random random = new Random();

            string[] names = { "John", "Mary", "Mari", "Hans", "Marika" };
            int randomk = random.Next(1, 11);

            List<Student> students = new List<Student>();

            for (int i = 0; i < randomk; i++)
            {
                string name = names[random.Next(names.Length)];
                int randomDays = random.Next(-20, -1);
                int randomMinutes = random.Next(-60, 0);
                DateTime time = DateTime.Now.AddMinutes(randomMinutes).AddDays(randomDays);

                Student student = CreateRandomStudent(name, time, random);
                students.Add(student);
            }

            foreach (var student in students)
            {
                student.msg();
            }
            Student studentObj = new Student("", "", DateTime.Now);
            string mostPopularMessage = studentObj.GetPopInfoN(students);

            Console.WriteLine(mostPopularMessage);
        }

        public static Student CreateRandomStudent(string name, DateTime time, Random random)
        {
            string content = Guid.NewGuid().ToString().Substring(0, 10);
            int likes = random.Next(0, 100);

            Student student = new Student(content, name, time);
            for (int i = 0; i < likes; i++)
            {
                student.AddLike();
            }

            return student;
        }
    }
}