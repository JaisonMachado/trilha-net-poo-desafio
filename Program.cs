using DesafioPOO.Models;
using static System.Console;

// TODO: Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO
WriteLine("Smartphone Nokia");
Smartphone Nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111111", memoria: 64);
Nokia.Ligar();
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("\n");
Console.WriteLine("Smartphone Iphone");
Smartphone Iphone = new Iphone(numero: "333352222", modelo: "Iphone 12", imei: "999999999", memoria: 128);
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("WhatsApp");
