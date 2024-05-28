using System.Text.Json.Serialization;

namespace ScreenSoudAPI.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; } // "?" significa que pode ser nulo

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirMusica()
    {
        Console.WriteLine($"Artista: {Artista} \n" +
            $"Música: {Nome} \n" +
            $"Duração: {Duracao / 1000} \n" +
            $"Gênero: {Genero}");
    }
}
