string caminhoArquivo = @"C:\Users\paulo\Documents\dados\MeuDiretorio2\poesia.txt";

try
{
    using FileStream fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
    using StreamReader leitor = new StreamReader(fs);
    string? linha;
    while((linha = leitor.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }

}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();
