using Console_Reverse_String;

Console.WriteLine("Aplicação para Inverter String\r\n\r\n ");
Console.Write("Entre com uma palavra: ");
string? strInput = Console.ReadLine();

if (String.IsNullOrEmpty(strInput))
    Console.WriteLine("Erro. Você não forneceu nenhuma palavra!");
else
    Console.WriteLine($"A palavra inversa é {new ReverseString().Reverse(strInput)}");

Console.WriteLine();
Console.WriteLine("Pressione Qualquer tecla para Terminar");
Console.ReadKey();
