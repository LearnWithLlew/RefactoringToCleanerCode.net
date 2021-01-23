public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        switch (st)
        {
            case ScoringType.Pair:
            {
                return CalculatePairScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }

            case ScoringType.TwoPair:
            {
                return CalculateTwoPairScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }

            case ScoringType.FullHouse:
            {
                return CalculateFullHouseScore.Nonsense3(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }

            case ScoringType.FiveOfAKind:
            {
                return Nonsense4(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }

        return 0;
    }

    private static int Nonsense4(int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
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
                const int bigScore = 50;
                return bigScore;
            }
        }

        return 0;
    }
}