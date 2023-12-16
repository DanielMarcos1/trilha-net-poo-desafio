using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("+55 11 99973-4531", "iPhone 14 PRO MAX", "0849751127584612309", 128);
iphone.Ligar();
// Joãozinho não atendeu, mas retornou a ligação
iphone.ReceberLigacao();
// Joãozinho pediu para instalarmos o app para jogar juntos
iphone.InstalarAplicativo("8 Ball Pool - Sinuca Online");

Nokia nokia = new Nokia("+55 11 98856-7594", "Nokia G60 5G", "5128764756948655239456", 128);
nokia.Ligar();
// Roberto não atendeu, mas retornou a ligação
nokia.ReceberLigacao();
// Roberto nos pediu para instalar o instagram
nokia.InstalarAplicativo("Instagram");