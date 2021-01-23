public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        {
            if (new CalculatePairScore().ShouldCalculate(scoringType))
            {
                return new CalculatePairScore().Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }

        {
            if (new CalculateTwoPairScore().ShouldCalculate(scoringType))
            {
                return new CalculateTwoPairScore().Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }

        {
            if (new CalculateFullHouseScore().ShouldCalculate(scoringType))
            {
                return new CalculateFullHouseScore().Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }
        if (new CalculateFiveOfAKindScore().ShouldCalculate(scoringType))
        {
            return new CalculateFiveOfAKindScore().Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        return 0;
    }
}