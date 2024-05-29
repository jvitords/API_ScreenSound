using System.Text.Json.Serialization;

namespace ScreenSoudAPI.Modelos;

internal class Musica
{
    private string [] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"};

    [JsonPropertyName("song")] // método p/ receber informação do arquivo json
    public string? Nome { get; set; } // "?" significa que pode ser nulo

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }
    
    public string Tonalidade {
        get
        {
            return tonalidades[Key]; // pegando o índice p/ ver a tonalidade na lista de tonalidades
        }
    }
    public void ExibirMusica()
    {
        Console.WriteLine($"Artista: {Artista} \n" +
            $"Música: {Nome} \n" +
            $"Duração: {Duracao / 1000} \n" +
            $"Gênero: {Genero}\n" +
            $"Tonalidade: {Tonalidade}");
    }
}
