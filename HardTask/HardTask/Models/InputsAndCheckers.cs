using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using HardTask.CustomException;
namespace HardTask.Models
{
    internal class InputsAndCheckers
    {
        static public string NumberInput()
        {
            StringBuilder numberInput = new StringBuilder(); //max:9940557020323-13 min-557020323-9
            char choise;
            bool isRunning = true;
            while (numberInput.Length <= 13 && isRunning)
            {
                Console.Clear();
                Console.Write(@$"
        {numberInput}
-------------------------
|       |       |       |
|   1   |   2   |   3   |
-------------------------
|       |       |       |
|   4   |   5   |   6   |
-------------------------
|       |       |       |
|   7   |   8   |   9   |
-------------------------
|remove1|       |       |
|char  *|   0   | #-stop|
-------------------------
Choise:");

                choise = CharInput();

                switch (choise)
                {
                    case '1':
                        numberInput.Append("1");
                        break;
                    case '2':
                        numberInput.Append("2");
                        break;
                    case '3':
                        numberInput.Append("3");
                        break;
                    case '4':
                        numberInput.Append("4");
                        break;
                    case '5':
                        numberInput.Append("5");
                        break;
                    case '6':
                        numberInput.Append("6");
                        break;
                    case '7':
                        numberInput.Append("7");
                        break;
                    case '8':
                        numberInput.Append("8");
                        break;
                    case '9':
                        numberInput.Append("9");
                        break;
                    case '0':
                        numberInput.Append("0");
                        break;
                    case '#':
                        isRunning = false;
                        break;
                    case '*':
                        if (numberInput.Length >= 1) numberInput.Remove(numberInput.Length - 1, 1);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }
            if (numberInput.Length > 13 || numberInput.Length < 9) throw new NumberLengthException("Number Length Exception");
            return numberInput.ToString();
        }


        static public string NameInput()
        {
            //a
            return "";
        }


        static public byte ByteInput()
        {
            byte choise;
            while (!byte.TryParse(Console.ReadLine(), out choise))
            {
                Console.Write("Choise:");
            }
            return choise;
        }


        static public char CharInput()
        {
            char choise;
            while (!char.TryParse(Console.ReadLine(), out choise))
            {
                Console.Write("Choise:");
            }
            return choise;
        }


        
    }
}
