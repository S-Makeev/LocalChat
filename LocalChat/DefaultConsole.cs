using System;

namespace LocalChat
{
    public class DefaultConsole : IConsole
    {
        public ConsoleColor ForegroundColor { get => Console.ForegroundColor; set => Console.ForegroundColor = value; }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void ResetColor()
        {
            Console.ResetColor();
        }

        public void Write(string value)
        {
            Console.Write(value);
        }

        public void WriteLine(string value)
        {
            Write(value + "\n");
        }
    }
}
