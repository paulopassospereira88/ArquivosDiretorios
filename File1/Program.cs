string caminhoOrigem = @"C:\Users\paulo\Documents\dados\txt\file1.txt";
string caminhoDestino = @"C:\Users\paulo\Documents\dados\file1.txt";

//Criar arquivo
//File.Create(caminhoOrigem);

if (!File.Exists(caminhoDestino))
{
    try
    {
        File.WriteAllText(caminhoOrigem, "Paulo Passos \r\n");

        string novoTexto = "O poeta é um fingidor " +
                                  Environment.NewLine +
                                 "Finge tão completamente\r\n" +
                                 "Que chega a fingir que é dor\r\n" +
                                 "A dor que deveras sente.\r\n";

        File.AppendAllText(caminhoOrigem, novoTexto);

        // le o conteudo do arquivo
        Console.WriteLine("\nConteudo e informacoes do arquivo :");
        string conteudo = File.ReadAllText(caminhoOrigem);
        Console.WriteLine(conteudo);

        Console.WriteLine($"Ultima modificacao feita em : {File.GetLastWriteTime(caminhoOrigem)}");
        Console.WriteLine($"Ultimo acesso feito em : {File.GetLastAccessTime(caminhoOrigem)}");

        string[] linhas = File.ReadAllLines(caminhoOrigem);
        foreach (var linha in linhas)
        {
            Console.WriteLine(linha);
        }

        var caminhoCopia = @"C:\Users\paulo\Documents\dados\txt\file1_copia.txt";
        Console.WriteLine($"\nCopia de {caminhoOrigem} para {caminhoCopia}");
        File.Copy(caminhoOrigem, caminhoCopia);

        Console.WriteLine($"\nMovendo {caminhoOrigem} para {caminhoDestino}");
        File.Move(caminhoOrigem, caminhoDestino);

        //Excluir
        Console.WriteLine($"\nExcluindo {caminhoOrigem}, {caminhoDestino} e {caminhoCopia}");
        File.Delete(caminhoOrigem);
        File.Delete(caminhoDestino);
        File.Delete(caminhoCopia);
    }
    catch (IOException e)
    {
        Console.WriteLine(e.Message);
    }
}
Console.WriteLine("Concluido");
