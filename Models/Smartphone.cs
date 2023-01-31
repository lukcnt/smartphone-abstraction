using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartphone_abstraction.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        private string Model { get; set; }
        private string Imei { get; set; }
        private int Memory { get; set; }

        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            Imei = imei;
            Memory = memory;
        }

        public void Call()
        {
            Console.WriteLine("Calling...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Receiving call...");
        }

        public abstract void InstallApp(string appName);
    }
}