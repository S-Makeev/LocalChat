using System;

namespace LocalChat
{
    public class LoginCommand
    {
        public User User { get; set; }
        private readonly IConsole Consol;

        public LoginCommand(User user, IConsole consol)
        {
            User = user;
            Consol = consol;
        }

        public void Execute()
        {
            Consol.Write("$ Enter your login: ");
            var login = Consol.ReadLine();

            Consol.Write("$ Enter your pass: ");
            var pass = Console.ReadLine();

            if (login == "login" && pass == "pass")
            {
                User.IsAuthorized = true;
                Consol.ForegroundColor = ConsoleColor.Green;
                Consol.WriteLine("$ Login success!");
                Consol.ResetColor();
            }
            else if (login == "admin" && pass == "12345")
            {
                User.IsAuthorized = true;
                User.IsAdmin = true;
                Consol.ForegroundColor = ConsoleColor.Green;
                Consol.WriteLine("$ [ADMIN] Login success!");
                Consol.ResetColor();
            }
            else
            {
                Consol.ForegroundColor = ConsoleColor.Red;
                Consol.WriteLine("$ Login fail!");
                Consol.ResetColor();
            }
        }
    }
}
