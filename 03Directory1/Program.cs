var caminhoDiretorio = @"C:\Users\paulo\Documents\dados\teste1";
var caminhoDestino = @"C:\Users\paulo\Documents\dados\teste2";

CriarDiretorio(caminhoDiretorio);
ObterUmSubdiretorio(caminhoDiretorio);
MovendoDiretorio(caminhoDiretorio, caminhoDestino);
//DeletarDiretorio(caminhoDiretorio);

Console.ReadKey();

static void CriarDiretorio(string caminhoDiretorio)
{
    Console.WriteLine("\nCriando um novo diretorio");

    try
    {
        if (!Directory.Exists(caminhoDiretorio))
        {
            Directory.CreateDirectory(caminhoDiretorio);
            Console.WriteLine($"Diretorio {caminhoDiretorio} criado com sucesso");
        }
        else
        {
            Console.WriteLine($"O diretorio {caminhoDiretorio} ja existe");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

static void DeletarDiretorio(string caminhoDiretorio)
{
    Console.WriteLine("\nExcluindo um diretorio");

    try
    {
        if (Directory.Exists(caminhoDiretorio))
        {
            Directory.Delete(caminhoDiretorio);
            Console.WriteLine($"Diretorio {caminhoDiretorio} excluido com sucesso");
        }
        else
        {
            Console.WriteLine($"O diretorio {caminhoDiretorio} ja existe");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

static void ObterUmSubdiretorio(string caminhoDiretorio)
{
    Console.WriteLine("\nMovendo um diretorio");

    try
    {
        if (Directory.Exists(caminhoDiretorio))
        {
            string[] subdiretorios = Directory.GetDirectories(caminhoDiretorio);
            foreach(var subdir in subdiretorios)
            {
                Console.WriteLine(subdir);
            }
        }
        else
        {
            Console.WriteLine($"O diretorio {caminhoDiretorio} ja existe");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

static void MovendoDiretorio(string caminhoDiretorio, string caminhoDestino)
{
    Console.WriteLine("\nObtendo os subdiretorios de um diretorio");

    try
    {
        if (Directory.Exists(caminhoDiretorio))
        {
            Directory.Move(caminhoDiretorio, caminhoDestino);
            Console.WriteLine("Diretorio movido com sucesso");
        }
        else
        {
            Console.WriteLine($"O diretorio {caminhoDiretorio} ja existe");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}