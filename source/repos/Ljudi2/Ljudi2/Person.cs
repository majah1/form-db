using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ljudi2
{
    public class Person
    {
        int id;
        string firstName;
        string lastName;
        int age;
        string fullName;

        public int Age { get => age; set => age = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public Person(int id, string FirstName, string LastName, int age)
        {
            this.Id = id;
            this.Age = age;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FullName = FirstName + "" + LastName;
        }


    }
}
