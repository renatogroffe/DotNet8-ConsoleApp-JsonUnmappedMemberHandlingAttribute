using System.Runtime.InteropServices;
using System.Text.Json;
using ConsoleAppJsonUnmapped.Models;

Console.WriteLine("***** Testes com .NET 8 | JsonUnmappedMemberHandlingAttribute *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

var dadosPessoas = new string[] { """{"Nome" : "Maria", "Peso" : 50.0, "Idade" : 27 }""",
    """{"Nome" : "Pedro", "Idade" : 40 }""" };
foreach (var dadosPessoa in dadosPessoas)
{
    try
    {
        Console.WriteLine();
        Console.WriteLine($"Valor a ser desserializado = {dadosPessoa}");
        var pessoa = JsonSerializer.Deserialize<Pessoa>(dadosPessoa)!;
        Console.WriteLine($"Valor da propriedade '{nameof(pessoa.Nome)}' = {pessoa.Nome}");
        Console.WriteLine($"Valor da propriedade '{nameof(pessoa.Idade)}' = {pessoa.Idade}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu uma exceção do tipo '{ex.GetType().FullName}'");
    }
}