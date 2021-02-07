using System.Linq;

public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        return (from scorer in new IScorer[] {new DicePairScoreCalculator(), new DiceTwoPairScoreCalculator(), new DiceFullHouseScoreCalculator(), new DiceFiveOfAKindScoreCalculator()} where scorer.IsScorable(scoringType) select scorer.CalculateScore(dieOne, dieTwo, dieThree, dieFour, dieFive)).FirstOrDefault();
    }
}