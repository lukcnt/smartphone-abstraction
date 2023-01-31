using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartphone_abstraction.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {

        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing application {appName} for Iphone");
        }
    }
}