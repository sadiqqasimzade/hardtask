using System;
using System.Collections.Generic;
using System.Text.Json;
namespace HardTask.Models
{
    class Operator
    {
        public string OperatorName { get; set; }
        public double Tarif { get; set; }
        
        static void Send()
        {
            JsonSerializer.Serialize("");
        }

        //static void Recive()
        //{
        //   string text= JsonSerializer.Deserialize();
        //}
    }
}
