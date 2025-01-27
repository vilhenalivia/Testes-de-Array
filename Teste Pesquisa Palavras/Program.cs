
TestaBuscaPalavras();

void TestaBuscaPalavras()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1} a palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string item in arrayDePalavras)
    {
        if (item.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }

    }

}