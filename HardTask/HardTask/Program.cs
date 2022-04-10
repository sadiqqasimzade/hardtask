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
             5)Call
             
             
             
             */
            List<Person> persons=new List<Person>();
            

            Person person1 = new Person("Eli", "4254235253");
            InputsAndCheckers.NumberInput(person1);
            Person person2 = new Person("Aysu", "08845698520");

            person1.contacts.AddContact("Aysu1", person2.Number);
            person1.contacts.AddContact("Aysu2", "4542352345234");

            person1.AddBalance(0.16);

            Call.CallNumber(person1, person2);
            Call.CallNumber(person1, person2);

            person1.callHistory.ShowHistory();

          

        }
    }
}
