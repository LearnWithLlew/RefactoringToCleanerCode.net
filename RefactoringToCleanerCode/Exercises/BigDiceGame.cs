public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        if (st == ScoringType.Pair)
        {
            return CalculatePairScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        if (st == ScoringType.TwoPair)
        {
            return CalculateTwoPairScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        if (st == ScoringType.FullHouse)
        {
            return CalculateFullHouseScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }
        if (st == ScoringType.FiveOfAKind)
        {
            return CalculateFiveOfAKindScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        return 0;
    }
}