using System;
using System.Collections.Generic;
using System.Threading;
using HardTask.Models;
namespace HardTask
{
    class Program
    {
        static void Main()
        {
 
            Person main = new Person();
            main.Name = InputsAndCheckers.NameInput();

            NIPoint:
            try
            {
                InputsAndCheckers.NumberInput(main);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto NIPoint;
            } 
            byte counter = 0;
            Person person=new Person();

            byte choise;

            do
            {
                choise = InputsAndCheckers.NumberInput<byte>("1)Add Person and add it into contacts\n2)Working With Contacts\n3)callhistoy\n4)Add Balance\n5)Change Ring\n6)Call\n0)Exit\nChoise:");
                switch (choise)
                {
                    case 0: break;
                    case 1:
                        Point:
                        person = new Person();
                        try
                        {
                        InputsAndCheckers.NumberInput(person);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Point;
                        }
                        person.Name = InputsAndCheckers.NameInput();
                        main.contacts.AddContact(person.Name,person.Number);
                        break;
                    case 2:
                        do
                        {
                            choise = InputsAndCheckers.NumberInput<byte>("1)show all\n2)delete person from contacts\n0)Exit");
                            switch (choise)
                            {
                                case 1:
                                    main.contacts.ShowContacts();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter Contact name");
                                    main.contacts.RemoveContact(Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("Wrong Input");
                                    break;
                            }
                        } while (choise != 0);

                        break;
                    case 3:
                        do
                        {
                            choise = InputsAndCheckers.NumberInput<byte>("1)showall\t2)delete history\n0)Exit\nChoise:");
                            switch (choise)
                            {
                                case 0: break;
                                case 1:
                                    main.callHistory.ShowHistory();
                                    break;
                                case 2:
                                    main.callHistory.ClearHistory();
                                    break;
                                default:
                                    Console.WriteLine("Wrong Input");
                                    break;
                            }
                        } while (choise != 0);
                        break;

                    case 4:
                        double addbalance= InputsAndCheckers.NumberInput<double>("How much do you want to add:");
                        main.AddBalance(addbalance);
                        break;
                    case 5:
                        try
                        {
                            main.Ringtone = Ringtones.ringTones[counter];
                            counter++;
                            Console.WriteLine("Ring Changed");
                        }
                        catch (Exception)
                        {
                            counter = 0;
                        }
                        break;
                    case 6:
                        if (person.Name == default) Console.WriteLine("Create Person First");
                        else Call.CallNumber(main, person);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }



            } while (true);







        }
    }
}
