using System.Text.Json;

namespace ScreenSoudAPI.Modelos;

internal class MusicasFavoritas 
{
    public string Nome { get; set; }
    public List<Musica> listaDeMusicasFavoritas { get; }

    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        listaDeMusicasFavoritas = new List<Musica>();
    }
    public void AdicionarMusicaFavorita(Musica musica)
    {
        listaDeMusicasFavoritas.Add(musica);
    }
    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Músicas favoritas do {Nome}\n");
        foreach (var musica in listaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson() // função que gera um arquivo json da lista de músicas favoritas
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = listaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.Json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo {nomeDoArquivo} foi criado com sucesso.\n" +
            $"\nLink do arquivo Json: {Path.GetFullPath(nomeDoArquivo)}");
    }
}
