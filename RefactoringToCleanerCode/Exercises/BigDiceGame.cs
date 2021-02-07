public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        switch (scoringType)
        {
            case ScoringType.Pair:
            {
                return DicePairScoreCalculator.ObviousNonsense(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }

            case ScoringType.TwoPair:
            {
                return DiceTwoPairScoreCalculator.ObviousNonsenseTwo(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }

            case ScoringType.FullHouse:
            {
                return DiceFullHouseScoreCalculator.ObviousNonsenseThree(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }

            case ScoringType.FiveOfAKind:
            {
                return ObviousNonsenseFour(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }

        return 0;
    }

    private static int ObviousNonsenseFour(int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
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
}