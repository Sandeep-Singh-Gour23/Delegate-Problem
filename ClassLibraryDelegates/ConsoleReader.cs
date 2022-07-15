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
                string res = GetResponse(input, word, num, junk);
                Console.WriteLine(res);
            }
        }
        public string GetResponse(string input, Delegates.OnWord word, Delegates.OnNumber num, Delegates.OnJunk junk)
        {
           
            if (input.All(Char.IsLetter))
               return word(input);

            else if (input.All(Char.IsDigit))
               return num(input);

            else if (input.All(Char.IsLetterOrDigit))
               return word(input);

            else return junk(input);


        }
    }
}
