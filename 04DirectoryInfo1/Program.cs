var caminhoDiretorio = @"C:\Users\paulo\Documents\dados";

var dirOrigem = new DirectoryInfo(caminhoDiretorio);

Console.WriteLine("Nome do diretorio: " + dirOrigem.Name);
Console.WriteLine("Caminho completo do diretorio: " +dirOrigem.FullName);
Console.WriteLine("Data de criacao: " +dirOrigem.CreationTime);
Console.WriteLine("Ultimo acesso: " +dirOrigem.LastAccessTime);
Console.WriteLine("Ultima modificacao: " +dirOrigem.LastWriteTime);
Console.WriteLine("Atributos: " + dirOrigem.Attributes);

Console.WriteLine("\nCriando um novo diretorio:");
var novoDiretorio = new DirectoryInfo(@"C:\Users\paulo\Documents\dados\MeuDiretorio");
try
{
    if (!novoDiretorio.Exists)
    {
        novoDiretorio.Create();
        Console.WriteLine($"Criando um novo diretorio {novoDiretorio.FullName}");
    }

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\nExcluindo um novo diretorio:");
try
{
    if (novoDiretorio.Exists)
    {
        novoDiretorio.Delete();
        Console.WriteLine($"Deletado diretorio {novoDiretorio.FullName}");
    }

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine($"\nExibindo os subdiretorios de {caminhoDiretorio}");
try
{
    foreach (var subdir in dirOrigem.GetDirectories())
    {
        Console.WriteLine($"\nSubdiretorio: {subdir.FullName}");
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}

Console.WriteLine($"\nExibindo os arquivos de {caminhoDiretorio}");
try
{
    foreach (var subdir in dirOrigem.GetFiles())
    {
        Console.WriteLine($"\nSubdiretorio: {subdir.FullName}");
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}

Console.WriteLine($"\nCriar um subdiretorio: {caminhoDiretorio}");
try
{
    dirOrigem.CreateSubdirectory("MeuDiretorio2");
    Console.WriteLine("Subdiretorio2 criado com sucesso!");

}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}


