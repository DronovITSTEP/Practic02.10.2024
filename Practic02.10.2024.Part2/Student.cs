using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic02._10._2024.Part2
{
    public class Student
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int GroupId {  get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {BirthDate.ToLongDateString()}";
        }
    }

    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
