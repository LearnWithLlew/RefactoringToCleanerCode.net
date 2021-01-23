public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        if (scoringType == ScoringType.Pair)
        {
            return CalculatePairScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        if (scoringType == ScoringType.TwoPair)
        {
            return CalculateTwoPairScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        if (scoringType == ScoringType.FullHouse)
        {
            return CalculateFullHouseScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }
        if (scoringType == ScoringType.FiveOfAKind)
        {
            return CalculateFiveOfAKindScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        return 0;
    }
}