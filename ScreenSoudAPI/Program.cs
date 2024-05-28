using ScreenSoudAPI.Modelos;
using ScreenSoudAPI.Filtros;
using System.Text.Json;

using (HttpClient  client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[0].ExibirMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "pop");
        //LinqFilter.ExibirMusicasDeUmArtista(musicas, "U2");


        var musicasFavoritas = new MusicasFavoritas("Vitor");
        musicasFavoritas.AdicionarMusicaFavorita(musicas[1]);
        musicasFavoritas.AdicionarMusicaFavorita(musicas[377]);
        musicasFavoritas.AdicionarMusicaFavorita(musicas[4]);
        musicasFavoritas.AdicionarMusicaFavorita(musicas[6]);
        musicasFavoritas.AdicionarMusicaFavorita(musicas[1467]);

        musicasFavoritas.ExibirMusicasFavoritas();

    }
    catch (Exception excessao)
    {
        Console.WriteLine($"Ocorreu um problema: {excessao.Message}");
    }
    
}
