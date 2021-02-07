internal class DicePairScoreCalculator
{
    public static int CalculateScore(int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        const int value = 2;
        int[] tallies1;
        tallies1 = new int[6];
        tallies1[dieOne - 1]++;
        tallies1[dieTwo - 1]++;
        tallies1[dieThree - 1]++;
        tallies1[dieFour - 1]++;
        tallies1[dieFive - 1]++;
        for (var i = 6 - 1; i >= 0; i--)
        {
            if (tallies1[i] >= value)
            {
                return (i + 1) * value;
            }
        }

        return 0;
    }

    public static bool IsScorable(ScoringType scoringType)
    {
        return scoringType == ScoringType.Pair;
    }
}