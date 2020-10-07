using System;

namespace LocalChat
{
    public class User
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public string Email { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsAuthorized { get; set; }


        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 18)
                {
                    _age = value;
                }
            }
        }

        public void InitUser()
        {
            Console.WriteLine("Please, enter your age: ");
            _age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your name: ");
            Name = Console.ReadLine();

            Console.WriteLine($"Welcome, {Name}!");
        }
    }
}
