using System;
using System.Collections.Generic;
using System.Text;

namespace LocalChat
{
    public class User
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public string Email { get; set; }

        public int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18)
                {
                    age = value;
                }
            }
        }

        public void sayHello()
        {
            Console.WriteLine($"Welcome, {Name}!");
        }

        /* public override string ToString()
         {
             return "Welcome, user: " + name;
         }*/
    }
}
