using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static Kordamine.StudentMain;

namespace Kordamine
{
    public class Student
    {
        private readonly string _content;
        private readonly string _author;
        private readonly DateTime _time;
        private int _likes;

        public string Name { get; }
        public int age;
        private readonly string _city;
        public string status;

        public Student(string content, string author, DateTime time)
        {
            this._content = content;
            this._author = author;
            this._time = time;
        }

        public int Likes { get => _likes; }
        public DateTime Time { get => _time; }
        public string Author { get => _author; }
        public string Content { get => _content; }

        public void AddLike()
        {
            _likes++;
        }

        public double GetPopularity()
        {
            double elapsed = DateTime.Now.Subtract(this._time).TotalSeconds;
            if (elapsed == 0)
            {
                return _likes;
            }
            return _likes / elapsed;

        }
        public void msg()
        {
            Console.WriteLine("Sisu: {0}\nAuthor: {1}\nTime: {2}\nPopularity: {3}\n-----------------------------", Content,Author,Time,GetPopularity());
        }
        public void CompareMsg()
        {
            Console.WriteLine(GetPopInfo(1, 2));
        }
        public string GetPopInfo(double esimene, double teine)
        {
            string result = "";
            if (esimene > teine) { result = "Esimene sõnum on populaarsem kui teine"; };
            if (teine > teine) { result = "Teine sõnum on populaarsem kui teine";  };
            return result;
        }
        public string GetPopInfoN(List<Student> messages)
        {
            string result = "";
            double popularity = 0;
            for (int i = 0; i < messages.Count; i++)
            {
                if (messages[i].GetPopularity()>popularity) { 
                    result = messages[i].Content + "on kõige populaarse sõnum, seda kirjutas " + messages[i].Author;
                }
            }
            return result;
        }

        //public string GetPopInfoN(List<Student> messages)
        //{

        //}

        //public Student(string name, int age, string city)
        //{
        //    Name = name;
        //    Age = age;
        //    _city = city;
        //}
        //public int Age
        //{
        //    get { return age; }
        //    set{
        //        age = value;
        //        if (age < 18) status = "alaealine";
        //        else status = "täiskasvanud";
        //    }
        //}
        //public string Status
        //{ get { return status; } }
        //public int Date()
        //{
        //    int currentDateTime = DateTime.Now.Year;
        //    return currentDateTime;
        //}

        //public string GetCity()
        //{
        //    return _city;
        //}

        //public void ShowInfo()
        //{
        //    Console.WriteLine(Name);
        //    Console.WriteLine(Age);
        //    Console.WriteLine(Status);
        //    Console.WriteLine(Date()-Age);
        //    Console.WriteLine(GetCity());
        //}
    }
}
