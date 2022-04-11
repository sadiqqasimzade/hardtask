using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using HardTask.CustomException;
namespace HardTask.Models
{
    abstract class InputsAndCheckers
    {
        static public void NumberInput(Person person)
        {
            //number remove limit 5 etmek?
            //regexle yoxlamaq?

            StringBuilder numberInput = new StringBuilder(); //max:9940557020323-13 min-557020323-9
            char choise;
            bool isRunning = true;
            OperatorInput(out string operatorname,out string operatorcode);
            person.phoneOperator.OperatorName = operatorname;

                numberInput.Append("994"+operatorcode);
            do
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
                        if (numberInput.Length >= 6) numberInput.Remove(numberInput.Length - 1, 1);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.Beep();
            } while (numberInput.Length <= 11 && isRunning);
            if (numberInput.Length !=12) throw new NumberLengthException("Number Length Exception");
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
            person.Number = numberInput.ToString();
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

        static public double DoubleInput()
        {
            double choise;
            do
            {
                Console.Write("Choise:");
            } while (!double.TryParse(Console.ReadLine(), out choise));
            return choise;  
        }

        public static void OperatorInput(out string operatorname,out string operatorcode)
        {
            int choise;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var @enum in Enum.GetValues(typeof(Operator.Operators)))
                stringBuilder.Append($"{(int)@enum}){@enum} ");
            do
            {
                choise = NumberInput<int>("Chose Operator\n" + stringBuilder + "\nChoise");
                foreach (var @enum in Enum.GetValues(typeof(Operator.Operators)))
                    if (choise ==(int) @enum)
                    {
                        operatorcode =Convert.ToString( (int)@enum);
                        operatorname = @enum.ToString();
                        return;
                    }
            } while (true);
        }

        static public T NumberInput<T>(string str)
        {
        Point:
            try
            {
                Console.Write("-----------------\n" + str + " :");
                dynamic temp = Console.ReadLine();
                temp = (T)Convert.ChangeType(temp, typeof(T));
                return temp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Point;
            }
        }

        public static string NameInput()
        {
            string name;
            do
            {
                Console.Write("Name:");
                name= Console.ReadLine();
            } while (String.IsNullOrEmpty(name)||String.IsNullOrWhiteSpace(name));
            return name;
        }

    }
}
