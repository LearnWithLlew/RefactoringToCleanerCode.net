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
                return CalculateFullHouseScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }

            case ScoringType.FiveOfAKind:
            {
                return CalculateFiveOfAKindScore.Nonsense4(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }

        return 0;
    }
}