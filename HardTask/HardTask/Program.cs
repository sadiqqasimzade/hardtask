﻿using System;
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
            
            !!!! *-metodu

            todo:sealed class phonebook-ancaq person yaradilanda cagila bilen (singleton?)
             */

            
            Person person1 = new Person("Eli", "4254235253");
            Person person2 = new Person("Aysu","08845698520" );

            person1.contacts.AddContact("Aysu1", person2.Number);
            person1.contacts.AddContact("Aysu2", "4542352345234");

            person1.AddBalance(0.16);

            person1.CallNumber(person2);

       
        }
    }
}
