using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone

Iphone i1 = new Iphone("11912345678", "3512341234", "Iphone 12", 256);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Whats App");

Console.WriteLine();

Nokia n1 = new Nokia("11987654321", "3598765987", "X2-01", 2);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Youtube");

