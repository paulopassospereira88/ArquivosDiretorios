string caminho = "C:\\Users\\paulo\\Documents\\dados\\poesia.txt";

char dirSeparador = Path.DirectorySeparatorChar;
Console.WriteLine("O separador de diretorio padrao e: " +dirSeparador);

string[] diretorios = caminho.Split(dirSeparador);

Console.WriteLine("Os diretorios e arquivos no caminho sao:");
foreach (var dir in diretorios)
{
    Console.WriteLine(dir);
}

string path1 = "C:\\Users\\paulo\\Documents\\dados";
string path2 = "MeuDiretorio2\\poesia.txt";

string pathCombinado = Path.Combine(path1, path2);
Console.WriteLine("\nCaminho Combinado: " + pathCombinado);

Console.WriteLine("\nNome do diretório : " + Path.GetDirectoryName(pathCombinado));
Console.WriteLine("\nExtensão: " + Path.GetExtension(pathCombinado));
Console.WriteLine("\nNome do arquivo: " + Path.GetFileName(pathCombinado));
Console.WriteLine("\nNome do arquivo sem extensão: " + Path.GetFileNameWithoutExtension(pathCombinado));
Console.WriteLine("\nPossui extensão ? : " + Path.HasExtension(pathCombinado));
Console.WriteLine("\nContém a raiz ?: " + Path.IsPathRooted(pathCombinado));
Console.WriteLine("\nNova extensão do arquivo: " + Path.ChangeExtension(pathCombinado, ".docx"));
Console.WriteLine("\nRaiz: " + Path.GetPathRoot(pathCombinado));
//
Console.WriteLine("\nNome de arquivo aleatório: " + Path.GetRandomFileName());
Console.WriteLine("\nNome de arquivo temporário: " + Path.GetTempFileName());
Console.WriteLine("\nCaminho Temporário: " + Path.GetTempPath());

char[] caracteresInvalidosEmArquivo = Path.GetInvalidFileNameChars();
Console.WriteLine("\nCaracteres inválidos em nome de arquivo: " + new string(caracteresInvalidosEmArquivo));