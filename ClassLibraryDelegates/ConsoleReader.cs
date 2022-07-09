using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDelegates
{
    public class ConsoleReader
    {
        public void Run(Delegates.OnWord word, Delegates.OnNumber num, Delegates.OnJunk junk)
        {
            while (true)
            {
                Console.WriteLine("Enter the value...or type quit for exit");
                string input = Console.ReadLine();

                if (input == "quit")
                    break;

                else if (input.All(Char.IsLetter))
                    word(input);

                else if (input.All(Char.IsDigit))
                    num(input);

                else if (input.All(Char.IsLetterOrDigit))
                    word(input);

                else junk(input);


            }
        }
    }
}
