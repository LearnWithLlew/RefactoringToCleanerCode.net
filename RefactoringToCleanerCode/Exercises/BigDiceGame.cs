using System.Linq;

public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        var scorers = new IScorer[]
        {
            new Pair(),
            new TwoPair(),
            new FullHouse(),
            new FiveOfAKind()
        };

        return scorers
            .Where(scorer => scorer.IsScorable(st))
            .Select(scorer => scorer.CalculateScore(die1, die2, die3, die4, die5))
            .FirstOrDefault();
    }
}