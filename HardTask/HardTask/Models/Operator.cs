using System;
using System.Collections.Generic;
using System.Text.Json;
namespace HardTask.Models
{
    class Operator
    {
        public string OperatorName { get; set; }
        public double Tarif { get; set; }

        public Operator(string name,double tarif)
        {
            OperatorName = name;
            Tarif = tarif; 
        }

        static void Send()
        {
            JsonSerializer.Serialize("");
        }

        public enum Operators {
            Azarcell50=50,Azarcell51=51,Azarcell10=10,Bakcell55=55,Bakcell99=99,Nar70=70,Nar77=77,NaxTell60=60
        }


        //static void Recive()
        //{
        //   string text= JsonSerializer.Deserialize();
        //}
    }
}
