using System.Linq;

public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        return GetScoringTypes()
            .Where(scorer => scorer.IsScorable(scoringType))
            .Select(scorer => scorer.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive))
            .FirstOrDefault();
    }

    private static IScorer[] GetScoringTypes()
    {
        return new IScorer[]
        {
            new DicePairScoreCalculator(), new DiceTwoPairScoreCalculator(), new DiceFullHouseScoreCalculator(),
            new DiceFiveOfAKindScoreCalculator()
        };
    }
}