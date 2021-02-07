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
                return ObviousNonsenseThree(dieOne, dieTwo, dieThree, dieFour, dieFive);
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

    private static int ObviousNonsenseThree(int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        int[] tallies;
        var _2 = false;
        int i;
        var _2_at = 0;
        var _3 = false;
        var _3_at = 0;


        tallies = new int[6];
        tallies[dieOne - 1] += 1;
        tallies[dieTwo - 1] += 1;
        tallies[dieThree - 1] += 1;
        tallies[dieFour - 1] += 1;
        tallies[dieFive - 1] += 1;

        for (i = 0; i != 6; i += 1)
        {
            if (tallies[i] == 2)
            {
                _2 = true;
                _2_at = i + 1;
            }
        }

        for (i = 0; i != 6; i += 1)
        {
            if (tallies[i] == 3)
            {
                _3 = true;
                _3_at = i + 1;
            }
        }

        if (_2 && _3)
        {
            return _2_at * 2 + _3_at * 3;
        }

        return 0;
    }
}