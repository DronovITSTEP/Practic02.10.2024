using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practic02._10._2024.Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ-запрос
            //результат = from имя_переменной in источник_данных select имя_переменной;

            int[] arrInt = { 5, 74, 97, 32, 44, 12, 2 };
            // вывод всех значений
            //var query = from i in arrInt select i;

            // вывод нечетных значений
            /*var query = from i in arrInt
                        where i % 2 == 1
                        select i;*/

            // сортировка значений
            /*var query = from i in arrInt
                        where i % 2 == 1
                        orderby i descending
                        select i;*/

            // группирирование значений
            //IEnumerable<IGrouping<int, int>>
            /*var query = from i in arrInt
                        group i by i % 10;*/
            /*var query = from i in arrInt
                        group i by i % 10
                        into res
                        where res.Count() > 1
                        select res;*/

            /*foreach (int i in query)
            {
                Console.WriteLine(i);
            }*/
            /*Console.WriteLine();
            foreach (var key in query)
            {
                Console.Write(key.Key + " - ");
                foreach (var val in key)
                {
                    Console.Write(val + ", ");
                }
                Console.WriteLine();
            }*/

            // временное хранилище другой коллекции
            /*string[] text =
            {
                "hreghg, rggg eger.",
                "thrth thrt! rthrtg eger, drg gg",
                "jtkthtrthth thr rthrth",
                "rththt. thrtg, rtegerg, ere"
            };

            var query = from p in text
                        let words = p.Split(",.! ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        from w in words
                        where w.Length > 4
                        select w;

            foreach (var w in query)
            {
                Console.WriteLine(w);
            }*/

            // объединение
            List<Student> students = new List<Student>
            {
                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    BirthDate = DateTime.Parse("1990-5-14"),
                    GroupId = 1,
                },
                new Student
                {
                    FirstName = "Petr",
                    LastName = "Petrov",
                    GroupId = 2,
                    BirthDate = DateTime.Parse("1980-12-2"),
                },
                new Student
                {
                    FirstName = "Sergey",
                    LastName = "Sergeev",
                    GroupId = 1,
                    BirthDate = DateTime.Parse("1995-7-10"),
                },
                new Student
                {
                    FirstName = "Elena",
                    LastName = "Elenova",
                    GroupId = 1,
                    BirthDate = DateTime.Parse("1998-12-23"),
                }
            };
            List<Group> groups = new List<Group> {
                new Group
                {
                    Id = 1,
                    Name = "C#"
                },
                new Group
                {
                    Id= 2,
                    Name = "C++"
                }
            };
            /*var query = from g in groups
                        join student in students
                        on g.Id equals student.GroupId
                        into res
                        from r in res
                        select r;

            foreach( var q in query )
            {
                Console.WriteLine($"{q.FirstName} {q.LastName} - " +
                    $"{groups.First(g => g.Id == q.GroupId).Name}");
            }*/
            /*var query = from g in groups
                        join student in students
                        on g.Id equals student.GroupId
                        select new {
                            NewFirstName = student.FirstName,
                            NewLastName = student.LastName,
                            NewGroup = g.Name
                        };

            foreach (var g in query)
            {
                Console.WriteLine(g);
            }*/

            /*var query = from s in students
                        where (DateTime.Now - s.BirthDate).Days / 365.25 >30
                        select s;*/
            /*var query = students
                .Where(s => (DateTime.Now - s.BirthDate).Days / 365.25 > 30)
                .Select(k => k);

            foreach (var stud in query)
            {
                Console.WriteLine(stud);
            }*/

            var query = from s in students
                        where s.BirthDate ==
                        (from b in students
                         select b.BirthDate).Max()
                        select s;
            var minAge = /*students*/(from s in students select s)
                .Min(s => (DateTime.Now - s.BirthDate)
                            .Days / 365.25);
           
            foreach (var s in query)
            {
                Console.WriteLine(s);
                Console.WriteLine((int)minAge);
            }
        }
    }
}
