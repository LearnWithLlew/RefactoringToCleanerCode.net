internal class FiveOfAKindScoreCalculator
{
    public static int CalculateScore(int die1, int die2, int die3, int die4, int die5)
    {
        int[] dice1 = {die1, die2, die3, die4, die5};
        var counts2 = new int[6];
        foreach (var die in dice1)
        {
            counts2[die - 1]++;
        }

        for (var i1 = 0; i1 != 6; i1++)
        {
            if (counts2[i1] == 5)
            {
                const int bigScore = 50;
                return bigScore;
            }
        }

        return 0;
    }

    public bool IsApplicable(ScoringType st)
    {
        return st == ScoringType.FiveOfAKind;
    }
}