var caminhoOrigem = @"C:\Users\paulo\Documents\dados\txt\poesia.txt";
var caminhoDestino = @"C:\Users\paulo\Documents\dados\poesia.txt";
var caminhoCopia = @"C:\Users\paulo\Documents\dados\poesia_copia.txt";

FileInfo arquivoOrigem = new FileInfo(caminhoOrigem);

Console.WriteLine("\nNome do arquivo: " +arquivoOrigem.Name);
Console.WriteLine("\nCaminho completo do arquivo: " +arquivoOrigem.FullName);
Console.WriteLine("\nO arquivo e somente leitura: " +arquivoOrigem.IsReadOnly);

var diretorioPai = arquivoOrigem.Directory;
Console.WriteLine("\nNome do diretorio: " +diretorioPai.Name);
Console.WriteLine("\nTamanho do arquivo: " +arquivoOrigem.Length+ " bytes");
Console.WriteLine("\nUltima gravacao: " +arquivoOrigem.LastWriteTime);

if (arquivoOrigem.Exists)
{
    Console.WriteLine($"\nO {caminhoOrigem} arquivo existe. Copiando para {caminhoCopia}");
    arquivoOrigem.CopyTo(caminhoCopia);
}
else
{
    Console.WriteLine($"\nO {caminhoOrigem} arquivo nao existe.");
}

Console.WriteLine($"\nMovendo {caminhoOrigem} para a {caminhoDestino}");
arquivoOrigem.MoveTo(caminhoDestino);