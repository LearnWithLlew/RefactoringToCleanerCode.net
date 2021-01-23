using System.Collections.Generic;

public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        {
            foreach (ICalculator calculator in new ICalculator[]{ new CalculatePairScore()})
            {
                if (calculator.ShouldCalculate(scoringType))
                {
                    return calculator.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
                }
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
            var calculator = new CalculateFiveOfAKindScore();
            if (calculator.ShouldCalculate(scoringType))
            {
                return calculator.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }

        return 0;
    }
}