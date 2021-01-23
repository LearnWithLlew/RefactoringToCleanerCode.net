using System.Collections.Generic;

public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        foreach (ICalculator calculator in new ICalculator[]
        {
            new CalculatePairScore(), new CalculateTwoPairScore(), new CalculateFullHouseScore(),
            new CalculateFiveOfAKindScore()
        })
        {
            if (calculator.ShouldCalculate(scoringType))
            {
                return calculator.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
            }
        }






        return 0;
    }
}