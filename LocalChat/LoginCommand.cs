using System;

namespace LocalChat
{
    public class LoginCommand
    {
        public User User { get; set; }

        public LoginCommand(User user)
        {
            User = user;
        }

        public void Execute()
        {
            Console.Write("$ Enter your login: ");
            var login = Console.ReadLine();

            Console.Write("$ Enter your pass: ");
            var pass = Console.ReadLine();

            if (login == "login" && pass == "pass")
            {
                User.IsAuthorized = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("$ Login success!");
                Console.ResetColor();
            }
            else if (login == "admin" && pass == "12345")
            {
                User.IsAuthorized = true;
                User.IsAdmin = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("$ [ADMIN] Login success!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("$ Login fail!");
                Console.ResetColor();
            }
        }
    }
}
