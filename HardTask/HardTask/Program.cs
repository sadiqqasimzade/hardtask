using System;
using HardTask.Models;
namespace HardTask
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            person.obj.Call(Person.obj)   1)Check Balance (min 3 qep) 2)isAvailable (await) 3)Nomrelrein contaktda olmagini yoxlamaq //person.obj!-person.obj
                                           
            Operator: 1)Tarif 2) Call() operatorlar ferqli olduqda tarif*2 


            2 proekt olur json faylla bir birine zeng edirler
             

            todo:sealed class phonebook-ancaq person yaradilanda cagila bilen (singleton?)
             */

            Person person1 = new Person("sadiq1",InputsAndCheckers.NumberInput());
            Person person2 = new Person("sadiq1", InputsAndCheckers.NumberInput());

            person1.CallNumber(person2);
            



        }
    }
}
