namespace Common.Utils
{
    using System;

    public static class Log
    {
        public static void Out(string msg, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void Error(string error)
        { 
            Out(error, ConsoleColor.DarkRed);
        }

        public static void Alert(string alert)
        {
            Out(alert, ConsoleColor.DarkYellow);
        }

        public static void Ok(string ok)
        {
            Out(ok, ConsoleColor.DarkGreen);
        }
    }
}
