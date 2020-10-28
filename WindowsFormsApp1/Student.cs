using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1
{
    public class Student
    {

        public string Name { set; get; }
        public int Group { set; get; }

        [Key]
        public Guid Id { set; get; }

        //[JsonIgnore]
        public int Age { set; get; }

        public Student() { Name = ""; Group = 0; Age = 0; Id = Guid.NewGuid(); }
        public Student(string N, int G, int A) { Name = N; Group = G; Age = A; }

        public static List<Student> CreateGroup()
        {
            var masiv = new List<Student>();
            masiv.Add(new Student("Виктория Гозда", 1, 25));
            masiv.Add(new Student("Валентина Сакаль", 2, 35));
            masiv.Add(new Student("Александр Мамай", 1, 45));
            masiv.Add(new Student("Роман Пожо", 3, 15));
            masiv.Add(new Student("Даниель Молнар", 3, 25));
            masiv.Add(new Student("Андрей Зозулич", 4, 35));
            masiv.Add(new Student("Инна Конар", 4, 45));
            masiv.Add(new Student("Михаил Цолиган", 2, 15));
            masiv.Add(new Student("Максим Миленевский", 4, 25));
            //masiv[9] = new Student("", "", 5);
            return masiv;
        }

        public override string ToString()
        {
            string s = Name + Age;
            return s;
        }
    } 
}
