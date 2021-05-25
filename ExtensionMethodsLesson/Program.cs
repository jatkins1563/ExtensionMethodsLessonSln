using System;

namespace ExtensionMethodsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var abc = "abc";
            abc.ToUpperCase().ToConsole();
        }
    }
}
