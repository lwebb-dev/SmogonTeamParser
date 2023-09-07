using System.Collections.Generic;
using System.IO;

namespace SmogonTeamParser.Parsers;

public static class SmogonSetParser
{
    public static SmogonSet GetSmogonSetFromFile(string file)
    {
        var lines = new List<string>();
        string line;
        using (var sr = new StreamReader(file))
        {
            line = sr.ReadLine();
            while (line != null)
            {
                lines.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }

        string[] linesArr = lines.ToArray();
        string item = linesArr[0].Split('@')[1].Trim(' ');
        string ability = linesArr[1].Split(':')[1].TrimStart(' ');
        string level = linesArr[2].Split(':')[1].TrimStart(' ');
        string nature = "Serious";
        StatValues ivs = SmogonIvParser.GetIndividualValuesFromSmogonExportLine(linesArr[3]);
        //StatValues evs = new StatValues();
        var moves = new List<string>();

        for (int i = 4; i <= linesArr.Length; i++)
        {
            // exit if larger than 7
            if (i >= 8)
                continue;

            moves.Add(linesArr[i].Replace("- ", ""));
        }

        var set = new SmogonSet
        {
            Level = int.Parse(level),
            Ability = ability,
            Item = item,
            Nature = nature,
            Ivs = ivs,
            //Evs = evs,
            Moves = moves.ToArray()
        };

        return set;
    }

    private static SmogonSet GetSampleSmogonSet()
    {
        return new SmogonSet
        {
            Level = 16,
            Ability = "Sand Stream",
            Item = "Sitrus Berry",
            Nature = "Serious",
            Ivs = new StatValues
            {
                Health = 20,
                Attack = 20,
                Defense = 20,
                SpecialAttack = 20,
                SpecialDefense = 20,
                Speed = 20
            },
            Evs = new StatValues(),
            Moves = new string[]
            {
                "Yawn",
                "Bulldoze",
                "Substitute",
                "Slack Off"
            }
        };
    }


}

