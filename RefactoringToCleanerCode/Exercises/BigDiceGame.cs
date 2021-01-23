public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        if (CalculatePairScore.ShouldCalculate(scoringType))
        {
            return CalculatePairScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        if (CalculateTwoPairScore.ShouldCalculate(scoringType))
        {
            return CalculateTwoPairScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        if (CalculateFullHouseScore.ShouldCalculate(scoringType))
        {
            return CalculateFullHouseScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }
        if (CalculateFiveOfAKindScore.ShouldCalculate(scoringType))
        {
            return CalculateFiveOfAKindScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        return 0;
    }
}