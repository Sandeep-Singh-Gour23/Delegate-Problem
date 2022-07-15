using System;

namespace ClassLibraryDelegates
{
    public class Delegates
    {
        public delegate string OnWord(string s);
        public delegate string OnNumber(string s);
        public delegate string OnJunk(string s);


        public static string isWord(string s)
        {
            return $"onWord delegate called. Entered value is a word i.e. {s}";
        }
        public static string isNumber(string s)
        {
            return $"onNumber delegate called. Entered value is a number i.e. {s}";
        }
        public static string isJunk(string s)
        {
            return $"onJunk delegate called. Entered value is a junk i.e. {s}";
        }
    }
}
