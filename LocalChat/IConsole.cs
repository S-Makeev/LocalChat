using System;

namespace LocalChat
{
    public interface IConsole
    {
        void Write(string value);
        void WriteLine(string value);
        void ResetColor();
        ConsoleColor ForegroundColor { get; set; }
        string ReadLine();
    }
}
