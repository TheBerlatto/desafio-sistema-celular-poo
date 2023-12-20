using DesafioPOO.Models;

Console.WriteLine("Comprei um Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "11987654321", modelo: "G11 Plus", imei:"11111111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("------------------------------------------------");

Console.WriteLine("Comprei um iPhone: ");
Smartphone iphone = new Iphone(numero: "11943215678", modelo: "15 Pro Max", imei: "222222222222222", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Buscar meu iPhone");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("TrueCaller");