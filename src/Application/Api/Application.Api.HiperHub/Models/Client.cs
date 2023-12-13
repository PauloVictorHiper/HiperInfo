namespace Application.Api.HiperHub.Models;

using System.Text.Json.Serialization;

public class Client
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("cpf")]
    public string Cpf { get; set; }

    [JsonPropertyName("companyId")]
    public Guid CompanyId { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }
    
    [JsonPropertyName("channels")]
    public Dictionary<string, string> Channels { get; init; }
}
