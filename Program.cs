using Celular.Models;

Nokia n1 = new Nokia("991521016", "z4", "8765", 8);
n1.Ligar();
n1.ReceberLigacao();
Console.WriteLine(n1.InstalarAplicativo("Spotify"));

Iphone i1 = new Iphone("84531017", "14 PRO", "9999", 16);
i1.Ligar();
i1.ReceberLigacao();
Console.WriteLine(i1.InstalarAplicativo("Deezer"));

