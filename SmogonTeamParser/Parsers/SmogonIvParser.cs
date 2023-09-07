namespace SmogonTeamParser;

public class SmogonIvParser
{
    public static StatValues GetIndividualValuesFromSmogonExportLine(string line)
    {
        string ivCollection = line.Split(':')[1].TrimStart(' ');
        string[] ivs = ivCollection.Split('/');

        int hp = FindHealthIvValue(ivs);
        int attack = FindAttackIvValue(ivs);
        int defense = FindDefenseIvValue(ivs);
        int specialAttack = FindSpecialAttackIvValue(ivs);
        int specialDefense = FindSpecialDefenseIvValue(ivs);
        int speed = FindSpeedIvValue(ivs);

        var result = new StatValues
        {
            Health = hp,
            Attack = attack,
            Defense = defense,
            SpecialAttack = specialAttack,
            SpecialDefense = specialDefense,
            Speed = speed
        };

        return result;
    }

    private static int FindHealthIvValue(string[] ivs)
    {
        foreach (string iv in ivs)
        {
            int? foundValue = FindIvValue(iv, "HP");

            if (foundValue.HasValue)
                return foundValue.Value;
        }

        return 31; // missing value = max iv
    }

    private static int FindAttackIvValue(string[] ivs)
    {
        foreach (string iv in ivs)
        {
            int? foundValue = FindIvValue(iv, "Atk");

            if (foundValue.HasValue)
                return foundValue.Value;
        }

        return 31; // missing value = max iv
    }

    private static int FindDefenseIvValue(string[] ivs)
    {
        foreach (string iv in ivs)
        {
            int? foundValue = FindIvValue(iv, "Def");

            if (foundValue.HasValue)
                return foundValue.Value;
        }

        return 31; // missing value = max iv
    }

    private static int FindSpecialAttackIvValue(string[] ivs)
    {
        foreach (string iv in ivs)
        {
            int? foundValue = FindIvValue(iv, "Spa");

            if (foundValue.HasValue)
                return foundValue.Value;
        }

        return 31; // missing value = max iv
    }

    private static int FindSpecialDefenseIvValue(string[] ivs)
    {
        foreach (string iv in ivs)
        {
            int? foundValue = FindIvValue(iv, "Spd");

            if (foundValue.HasValue)
                return foundValue.Value;
        }

        return 31; // missing value = max iv
    }

    private static int FindSpeedIvValue(string[] ivs)
    {
        foreach (string iv in ivs)
        {
            int? foundValue = FindIvValue(iv, "Spe");

            if (foundValue.HasValue)
                return foundValue.Value;
        }

        return 31; // missing value = max iv
    }



    private static int? FindIvValue(string iv, string desiredStat)
    {
        if (iv.IndexOf(" ") == 0)
            iv = iv.TrimStart(' ');

        string[] splitValues = iv.Split(' ');

        if (splitValues[1] == desiredStat)
            return int.Parse(splitValues[0]);

        return null;
    }
}
