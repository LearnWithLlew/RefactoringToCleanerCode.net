using System.Collections.Generic;
using System.Linq;

public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        return (GetCalculators()
            .Where(calculator => calculator.ShouldCalculate(scoringType))
            .Select(calculator => calculator.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive))).FirstOrDefault();
    }

    private static ICalculator[] GetCalculators()
    {
        return new ICalculator[]
        {
            new CalculatePairScore(), new CalculateTwoPairScore(), new CalculateFullHouseScore(),
            new CalculateFiveOfAKindScore()
        };
    }
}