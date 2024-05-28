using ScreenSoudAPI.Modelos;
using System.Linq;

namespace ScreenSoudAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        // filtrar todos os gêneros 
        var todosOsGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();
        Console.WriteLine($"----- Filtro de gêneros -----");
        foreach (var genero in todosOsGeneros)
        {
            Console.WriteLine($"Gênero - {genero}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        // filtrar artista de um determinado gênero
        var artistaPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"----- Artistas com música do gênero {genero} -----\n");
        foreach (var artista in artistaPorGeneroMusical) { 
            Console.WriteLine($"Artista: {artista}"); 
        }
    }

    public static void ExibirMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        // selecionar musicas de um determinado artista
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"----- Músicas do {artista} -----\n");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"Música: {musica}");
        }
    }
}
