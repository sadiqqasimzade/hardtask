using System;
using System.Threading;
using HardTask.Models;
namespace HardTask
{
    class Program
    {
        static void Main(string[] args)
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

            !!!! *-metodu

             */
            while (true)
            {
                Console.Beep(659, 300);
                Console.Beep(659, 300);
                Console.Beep(659, 300);
                Thread.Sleep(300);
                Console.Beep(659, 300);
                Console.Beep(659, 300);
                Console.Beep(659, 300);
                Thread.Sleep(300);
                Console.Beep(659, 300);
                Console.Beep(783, 300);
                Console.Beep(523, 300);
                Console.Beep(587, 300);
                Console.Beep(659, 300);
                Console.Beep(261, 300);
                Console.Beep(293, 300);
                Console.Beep(329, 300);
                Console.Beep(698, 300);
                Console.Beep(698, 300);
                Console.Beep(698, 300);
                Thread.Sleep(300);
                Console.Beep(698, 300);
                Console.Beep(659, 300);
                Console.Beep(659, 300);
                Thread.Sleep(300);
                Console.Beep(659, 300);
                Console.Beep(587, 300);
                Console.Beep(587, 300);
                Console.Beep(659, 300);
                Console.Beep(587, 300);
                Thread.Sleep(300);
                Console.Beep(783, 300);
                Thread.Sleep(300);
                Console.Beep(659, 300);
                Console.Beep(659, 300);
                Console.Beep(659, 300);
                Thread.Sleep(300);
                Console.Beep(659, 300);
                Console.Beep(659, 300);
                Console.Beep(659, 300);
                Thread.Sleep(300);
                Console.Beep(659, 300);
                Console.Beep(783, 300);
                Console.Beep(523, 300);
                Console.Beep(587, 300);
                Console.Beep(659, 300);
                Console.Beep(261, 300);
                Console.Beep(293, 300);
                Console.Beep(329, 300);
                Console.Beep(698, 300);
                Console.Beep(698, 300);
                Console.Beep(698, 300);
                Thread.Sleep(300);
                Console.Beep(698, 300);
                Console.Beep(659, 300);
                Console.Beep(659, 300);
                Thread.Sleep(300);
                Console.Beep(783, 300);
                Console.Beep(783, 300);
                Console.Beep(698, 300);
                Console.Beep(587, 300);
                Console.Beep(523, 600);
                Thread.Sleep(600);
            }

            Person person1 = new Person("Eli", "4254235253");
            InputsAndCheckers.NumberInput(person1);
            Person person2 = new Person("Aysu", "08845698520");

            person1.contacts.AddContact("Aysu1", person2.Number);
            person1.contacts.AddContact("Aysu2", "4542352345234");

            person1.AddBalance(0.16);

            Call.CallNumber(person1, person2);

            person1.callHistory.ShowHistory();

          

        }
    }
}
