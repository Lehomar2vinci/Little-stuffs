using System;
using System.Collections.Generic;

namespace CouperFoutre
{
    class UserInput
    {
        public string GetTextInput()
        {
            return Console.ReadLine();
        }

        public bool GetYesNoInput()
        {
            string response = Console.ReadLine().ToUpper();
            return response == "O";
        }
    }
}