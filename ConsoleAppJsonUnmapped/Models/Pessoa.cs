using System.Text.Json.Serialization;

namespace ConsoleAppJsonUnmapped.Models;

[JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Disallow)]
public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
}