using ScreenSoudAPI.Modelos;
using System.Linq;

namespace ScreenSoudAPI.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        // Listar todos os artistas existentes em ordem crescente
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("----- Lista de artistas ordenados -----");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"Artista - {artista}");
        }
    }
    
}
