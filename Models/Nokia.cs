using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartphone_abstraction.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {

        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing the application {appName} for Nokia.");
        }
    }
}