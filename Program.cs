using DesafioPOO.Models;

// ME CONTRATA XP!!!
// implementado: Realizar os testes com as classes Nokia e Iphone
Smartphone nokiaN1 = new Nokia(numero: "541658", modelo:"G21", imei: "1111111", memoria: 64);
Smartphone iphoneI1 = new Iphone(numero: "35481", modelo:"10 XR", imei: "2222222", memoria: 128);

Console.WriteLine("Smartphone Nokia:");
nokiaN1.Ligar();
nokiaN1.ReceberLigacao();
nokiaN1.InstalarAplicativo("XP Investimentos");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");
iphoneI1.Ligar();
iphoneI1.ReceberLigacao();
iphoneI1.InstalarAplicativo("XP Trader");