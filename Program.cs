using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("81993338673", "nokia32", "imeirandom", 128);
iphone.Ligar("1234567889");


Nokia nokia = new Nokia("81993338673", "nokia32", "imeirandom", 128);
nokia.AddContato("Leo", "123456789");
nokia.Ligar("123456789");
nokia.ReceberLigacao("123456789");
nokia.RemoverContato("123456789");
nokia.Ligar("123456789");