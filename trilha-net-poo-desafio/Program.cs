using DesafioPOO.Models;

Console.Clear();

// Realizar os testes com as classes Nokia e Iphone
var app1 = "Whatsapp";
var app2 = "Telegram";

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: string.Empty, modelo: "G400", imei: "111111111", memoria: 64);
nokia.Ligar();

nokia.Numero = "+5531987654321";
// nokia.IMEI = "222222222";

nokia.ReceberLigacao();
nokia.InstalarAplicativo(app1);

Console.WriteLine("\n");

Console.WriteLine("iPhone:");
Smartphone iphone = new Iphone(numero: "+5511996969696", modelo: "14 Pro Max", imei: "222222222", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
iphone.InstalarAplicativo(app1);
iphone.InstalarAplicativo(app2);