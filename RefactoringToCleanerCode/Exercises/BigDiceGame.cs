public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        if (CalculatePairScore.Nonsense(scoringType))
        {
            return CalculatePairScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        if (Nonsense2(scoringType))
        {
            return CalculateTwoPairScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        if (Nonsense3(scoringType))
        {
            return CalculateFullHouseScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }
        if (Nonsense4(scoringType))
        {
            return CalculateFiveOfAKindScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        return 0;
    }

    private static bool Nonsense4(ScoringType scoringType)
    {
        return scoringType == ScoringType.FiveOfAKind;
    }

    private static bool Nonsense3(ScoringType scoringType)
    {
        return scoringType == ScoringType.FullHouse;
    }

    private static bool Nonsense2(ScoringType scoringType)
    {
        return scoringType == ScoringType.TwoPair;
    }
}