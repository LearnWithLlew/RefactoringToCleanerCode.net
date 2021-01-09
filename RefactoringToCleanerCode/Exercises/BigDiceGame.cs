public static class BigDiceGame
{
    public static int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        foreach (ICategory category in new ICategory[]
            {new Pair(), new TwoPair(), new FullHouse(), new FiveOfAKind()})
        {
            if (category.Matches(scoringType))
            {
                return category.GetScore(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }
}