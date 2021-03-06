using System.Linq;

public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        var scoreCalculators = GetScoreCalculators();

        return scoreCalculators.Where(scoreCalculator => scoreCalculator.IsApplicable(st))
            .Select(scoreCalculator => scoreCalculator.CalculateScore(die1, die2, die3, die4, die5)).FirstOrDefault();
    }

    private static IScoreCalculator[] GetScoreCalculators()
    {
        return new IScoreCalculator[]
        {
            new PairScoreCalculator(), new TwoPairScoreCalculator(), new FullHouseScoreCalculator(),
            new FiveOfAKindScoreCalculator()
        };
    }
}