internal class DiceFiveOfAKindScoreCalculator
{
    public static int CalculateScore(int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        int[] dice1 = {dieOne, dieTwo, dieThree, dieFour, dieFive};
        var counts2 = new int[6];
        foreach (var die in dice1)
        {
            counts2[die - 1]++;
        }

        for (var i1 = 0; i1 != 6; i1++)
        {
            if (counts2[i1] == 5)
            {
                return 50;
            }
        }

        return 0;
    }

    public static bool IsScorable(ScoringType scoringType)
    {
        return scoringType == ScoringType.FiveOfAKind;
    }
}