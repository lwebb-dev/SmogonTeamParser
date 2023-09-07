using System;
using System.Text.Json;
using SmogonTeamParser.Parsers;

namespace SmogonTeamParser;

public class Program
{
    public static void Main(string[] args)
    {
        string file = args[0];
        SmogonSet set = SmogonSetParser.GetSmogonSetFromFile(file);
        string json = JsonSerializer.Serialize(set);
        Console.WriteLine(json);
    }
}