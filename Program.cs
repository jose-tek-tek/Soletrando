Console.WriteLine("Soletrando");

Console.WriteLine();

Console.WriteLine("Digite um texto a ser soletrado");

Console.WriteLine();

string texto = Console.ReadLine()!;

Console.WriteLine("\nSoletrado fica:\n");

Console.WriteLine(string.Join("-",texto.ToUpper().ToCharArray()));

Console.WriteLine();
