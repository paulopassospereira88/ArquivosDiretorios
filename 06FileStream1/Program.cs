string caminhoArquivo = @"C:\Users\paulo\Documents\dados\MeuDiretorio2\poesia.txt";

// FileStream fs = null;
StreamReader leitor = null;

try
{
    // fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
    // leitor = new StreamReader(fs);
    leitor = File.OpenText(caminhoArquivo);

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
finally
{
    if(leitor != null) leitor.Close();
    //if (fs != null) fs.Close();
}

Console.ReadKey();
