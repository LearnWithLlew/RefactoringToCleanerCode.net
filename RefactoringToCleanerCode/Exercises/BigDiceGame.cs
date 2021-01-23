public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        {
            var calculator = new CalculatePairScore();
            if (calculator.ShouldCalculate(scoringType))
            {
                return calculator.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }

        {
            var calculator = new CalculateTwoPairScore();
            if (calculator.ShouldCalculate(scoringType))
            {
                return calculator.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }

        {
            var calculator = new CalculateFullHouseScore();
            if (calculator.ShouldCalculate(scoringType))
            {
                return calculator.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }
        {
            if (new CalculateFiveOfAKindScore().ShouldCalculate(scoringType))
            {
                return new CalculateFiveOfAKindScore().Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }

        return 0;
    }
}