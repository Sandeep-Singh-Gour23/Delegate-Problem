using System;
using ClassLibraryDelegates;

namespace ConsoleAppforDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Problem....");
            ConsoleReader reader = new ConsoleReader();
            reader.Run(Delegates.isWord, Delegates.isNumber, Delegates.isJunk);


        }
    }
}
