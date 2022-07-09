using System;

namespace ClassLibraryDelegates
{
    public class Delegates
    {
        public delegate void OnWord(string s);
        public delegate void OnNumber(string s);
        public delegate void OnJunk(string s);


        public static void isWord(string s)
        {
            Console.WriteLine("onWord delegate called. Entered value is a word i.e. " + s);
        }
        public static void isNumber(string s)
        {
            Console.WriteLine("onNumber delegate called. Entered value is a number i.e. " + s);
        }
        public static void isJunk(string s)
        {
            Console.WriteLine("onJunk delegate called. Entered value is a junk i.e." +
                " " + s);
        }
    }
}
