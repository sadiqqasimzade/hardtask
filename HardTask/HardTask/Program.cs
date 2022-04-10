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
            /*
            person.obj.Call(Person.obj)   1)Check Balance (min 3 qep) 2)isAvailable (await) 3)Nomrelrein contaktda olmagini yoxlamaq //person.obj!-person.obj
            
            sercim 1)showcontact 2)add new person 

            Operator: 1)Tarif 2) Call() operatorlar ferqli olduqda tarif*2 


            2 proekt olur json faylla bir birine zeng edirler
            

            todo:sealed class phonebook-ancaq person yaradilanda cagila bilen (singleton?)

            //personun adi ve nomresi yaradilandan sonra verilir

            1)InputCheckersde telefonu deyismek
            2)2 yeni knopka sari qirmizi
            3)Operator secimine gore Telefon inputunda avtomatik 055/050/070 ... yerine yazmaq 
            4)person choise operator
            5)Ringtone
            !!!! *-metodu

             */
            /*
             
             
             1)yeni person elave etemek 
             2) Working with contacts
                1)showall
                2)person1 person2 .........    person1->person2
                3)personu contactdan silmek
             3) callhistoy
               1)showall
               2)delete history
             4)AddBalance
            5)Change ringtone
             6)Call
             
             
             
             */
            Person main = new Person();
            main.Name = InputsAndCheckers.NameInput();
            InputsAndCheckers.NumberInput(main);

            Person[] persons = new Person[0];

            byte choise;

            do
            {
                choise = InputsAndCheckers.NumberInput<byte>("1)Add Person\t2)Working With Contacts 3)callhistoy 0)Exit \nChoise:");
                switch (choise)
                {
                    case 0: break;
                    case 1:
                        Array.Resize(ref persons, persons.Length + 1);
                        persons[persons.Length - 1] = new Person();
                        persons[persons.Length - 1].Name = InputsAndCheckers.NameInput();
                        InputsAndCheckers.NumberInput(persons[persons.Length - 1]);
                        break;
                    case 2:
                        do
                        {
                            choise = InputsAndCheckers.NumberInput<byte>("1)show all 2)add person to contacts 3)delete person from contacts");
                            switch (choise)
                            {
                                case 1:
                                    foreach (Person p in persons)
                                    {
                                        Console.WriteLine(p);
                                    }
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.WriteLine("There is no choice like you type");
                                    break;
                            }
                        } while (choise != 0);

                        break;
                    case 3:
                        do
                        {
                            choise = InputsAndCheckers.NumberInput<byte>("1)showall\t2)delete history\nChoise:");
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
                        double addbalance= InputsAndCheckers.NumberInput<byte>("How much do you want to add:");
                        main.AddBalance(addbalance);
                        break;
                    case 5:
                        break;
                    case 6:

                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }



            } while (true);







        }
    }
}
