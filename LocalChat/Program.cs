using System;

namespace LocalChat
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.InitUser();

            while (true)
            {
                var input = RequestComman(user);

                switch (input.ToLower())
                {
                    case "/login":
                        var loginCommand = new LoginCommand(user);
                        loginCommand.Execute();
                        break;

                    case "/showip":
                        var showIpCommand = new ShowIpCmd();
                        showIpCommand.ShowIp();
                        break;

                    case "/exit":
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private static string RequestComman(User user)
        {
            Console.Write($"\n>");

            if (user.IsAuthorized)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" [auth]");
                Console.ResetColor();
            }

            if (user.IsAdmin)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($" [admin]");
                Console.ResetColor();
            }
            Console.Write($" {user.Name}: ");

            var input = Console.ReadLine();
            return input;
        }
    }
}
