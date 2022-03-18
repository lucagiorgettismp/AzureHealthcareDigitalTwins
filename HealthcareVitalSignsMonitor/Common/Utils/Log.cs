namespace Common.Utils
{
    using System;

    static public class Log
    {
        static public void Out(string msg, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        static public void Error(string error)
        { 
            Out(error, ConsoleColor.DarkRed);
        }

        static public void Alert(string alert)
        {
            Out(alert, ConsoleColor.DarkYellow);
        }

        static public void Ok(string ok)
        {
            Out(ok, ConsoleColor.DarkGreen);
        }
    }
}
