using System.Linq;
using System.Linq.Expressions;

public static class BigDiceGame 
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        return (GetScores()
            .Where(score => score.IsSomeCondition(st))
            .Select(score => score.Evaluate(die1, die2, die3, die4, die5))).FirstOrDefault();
    }

    private static IScore[] GetScores()
    {
        return new IScore[]
            {new PairScore(), new TwoPairScore(), new FullHouseScore(), new FiveOfKindScore()};
    }
}