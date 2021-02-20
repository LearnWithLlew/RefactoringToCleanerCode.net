using System.Linq;

public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        var scorers = new IScorer[] {new Pair(), new TwoPair(), new FullHouse(), new FiveOfAKind()};

        return (from scorer in scorers where scorer.IsScorable(st) select scorer.CalculateScore(die1, die2, die3, die4, die5)).FirstOrDefault();
    }
}