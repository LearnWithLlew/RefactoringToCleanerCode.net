using System.Linq;

public static class BigDiceGame
{
    public static int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        return (new ICategory[] {new Pair(), new TwoPair(), new FullHouse(), new FiveOfAKind()}
            .Where(category => category.Matches(scoringType))
            .Select(category => category.GetScore(die1, die2, die3, die4, die5))).FirstOrDefault();
    }
}