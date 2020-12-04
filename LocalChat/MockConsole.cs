using System;

namespace LocalChat
{
    public class MockConsole : IConsole
    {
        public ConsoleColor ForegroundColor { get; set; }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void ResetColor()
        {
        }

        public void Write(string value)
        {
            Console.Write("[" + value + "]");
        }

        public void WriteLine(string value)
        {
            Write(value + "\n");
        }
    }
}
