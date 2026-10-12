using System.Text.Json.Serialization;

namespace dotnet;

public class Cosmetic
{
    [JsonPropertyName("מזהה")]
    public int Id { get; set; }

    [JsonPropertyName("שם מוצר")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("מותג")]
    public string Brand { get; set; } = string.Empty;

    [JsonPropertyName("מחיר")]
    public decimal Price { get; set; }

    [JsonPropertyName("קטגוריה")]
    public string Category { get; set; } = string.Empty;
}