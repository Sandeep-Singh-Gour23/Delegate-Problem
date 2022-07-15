using ClassLibraryDelegates;
using System;
using Xunit;


namespace TestProjectforDelegates
{
    public class ConsoleReaderTest
    {
        [Fact]
        public void isWordTest()
        {
            ConsoleReader reader = new ConsoleReader();
            string input = "sandeep";
    
            Assert.Equal($"onWord delegate called. Entered value is a word i.e. {input}",
                reader.GetResponse(input, Delegates.isWord, Delegates.isNumber, Delegates.isJunk));
        }

        [Fact]
        public void isNumberTest()
        {
            ConsoleReader reader = new ConsoleReader();
            string input = "12345";

            Assert.Equal($"onNumber delegate called. Entered value is a number i.e. {input}",
                reader.GetResponse(input, Delegates.isWord, Delegates.isNumber, Delegates.isJunk));
        }

        [Fact]
        public void isJunkTest()
        {
            ConsoleReader reader = new ConsoleReader();
            string input = "@#$%^";

            Assert.Equal($"onJunk delegate called. Entered value is a junk i.e. {input}",
                reader.GetResponse(input, Delegates.isWord, Delegates.isNumber, Delegates.isJunk));
        }

        [Fact]
        public void isWord()
        {
            ConsoleReader reader = new ConsoleReader();
            string input = "sandeep12345";

            Assert.Equal($"onWord delegate called. Entered value is a word i.e. {input}",
                reader.GetResponse(input, Delegates.isWord, Delegates.isNumber, Delegates.isJunk));
        }
    }
}
