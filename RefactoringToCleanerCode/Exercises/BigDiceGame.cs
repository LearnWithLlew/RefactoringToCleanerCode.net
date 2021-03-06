public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        switch (st)
        {
            case ScoringType.Pair:
            {
                return PairScoreCalculator.FirstPararaph(die1, die2, die3, die4, die5);
            }

            case ScoringType.TwoPair:
            {
                return TwoPairScoreCalculator.SecondParagraph(die1, die2, die3, die4, die5);
            }

            case ScoringType.FullHouse:
            {
                return FullHouseScoreCalculator.ThirdParagraph(die1, die2, die3, die4, die5);
            }

            case ScoringType.FiveOfAKind:
            {
                return FourthParagraph(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }

    private static int FourthParagraph(int die1, int die2, int die3, int die4, int die5)
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
}