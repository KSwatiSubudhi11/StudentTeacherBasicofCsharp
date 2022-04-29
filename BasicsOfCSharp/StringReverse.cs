using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class StringReverse
    {
        public void Do()
        {
            Console.WriteLine("Please enter a string to reverse");
            string input = Console.ReadLine();

            // String is collection of characters.

            // for(initialization; condition; increament/decreament)
            // Mumbai => iabmuM => 6 (0-5)
            // strat reading form last index/char.
            // store/append it in a separate string.
            // decreament index position.

            string result = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result = result + input[i]; // i, ia, iab, iabm, iabmu, iabmuM
            }
            Console.WriteLine(result);
        }
    }
}
