internal class PairScoreCalculator
{
    public static int Calculate(int die1, int die2, int d3, int dieFour, int fifthDie)
    {
        const int value = 2;
        int[] tallies1;
        tallies1 = new int[6];
        tallies1[die1 - 1]++;
        tallies1[die2 - 1]++;
        tallies1[d3 - 1]++;
        tallies1[dieFour - 1]++;
        tallies1[fifthDie - 1]++;
        for (var i = 6 - 1; i >= 0; i--)
        {
            if (tallies1[i] >= value)
            {
                return (i + 1) * value;
            }
        }

        return 0;
    }

    public static bool IsSupported(ScoringType st)
    {
        return st == ScoringType.Pair;
    }
}