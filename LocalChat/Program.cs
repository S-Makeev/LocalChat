using System;

namespace LocalChat
{
    class Program
    {
        static IConsole _console;

        static void Main(string[] args)
        {
            _console = new DefaultConsole();

            var user = new User();
            user.InitUser();

            while (true)
            {
                var input = RequestComman(user);

                switch (input.ToLower())
                {
                    case "/login":
                        var loginCommand = new LoginCommand(user, _console);
                        loginCommand.Execute();
                        break;

                    case "/showip":
                        var showIpCommand = new ShowIpCmd();
                        showIpCommand.ShowIp();
                        break;

                    case "/exit":
                        Environment.Exit(0);
                        break;

                    case "/scd":
                        _console = new DefaultConsole();
                        break;

                    case "/scc":
                        _console = new MockConsole();
                        break;
                }
            }
        }

        private static string RequestComman(User user)
        {
            _console.Write($"\n>");

            if (user.IsAuthorized)
            {
                _console.ForegroundColor = ConsoleColor.Green;
                _console.Write($" [auth]");
                _console.ResetColor();
            }

            if (user.IsAdmin)
            {
                _console.ForegroundColor = ConsoleColor.Red;
                _console.Write($" [admin]");
                _console.ResetColor();
            }
            _console.Write($" {user.Name}: ");

            var input = _console.ReadLine();
            return input;
        }
    }
}
