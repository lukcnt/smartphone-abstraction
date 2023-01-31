using smartphone_abstraction.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(number: "44998147466", model: "C20", imei: "1234562355", memory: 128);
nokia.Call();
nokia.InstallApp("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(number: "44999661782", model: "XR", imei: "7894564444", memory: 256);
iphone.ReceiveCall();
iphone.InstallApp("Instagram");
