var costs = new int[] { 100, 500, 1000, 1500, 2000, 3000, 4000 };

for (int dailyClaims = 1; dailyClaims <= 7; dailyClaims++)
{
    Console.WriteLine($"{dailyClaims} daily claim(s):");
    Console.WriteLine("XP");
    int totalPoints = 0;

    for (int level = 0; level < 50; level++)
    {
        var claims = new int[dailyClaims];
        int points = level / 10 + 1;
        totalPoints += points;

        //int Sum() => new int[7].Select((_, i) => i >= claims.Length ? 0 : claims[i])
        //             .Zip(costs, (a, b) => a*b).Sum();

        for (int i = 0; claims.Sum() < totalPoints; i++)
            claims[i % dailyClaims]++;

        Console.WriteLine("=" + string.Join('+', claims.Take(dailyClaims).Select((n, idx) => $"{n}*{costs[idx]}")));
    }

    Console.WriteLine();
}
