

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
}
