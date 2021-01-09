public static class BigDiceGame
{
    public static int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        foreach (INonSenseApple appleSauce in new INonSenseApple[]
            {new Pair(), new TwoPair(), new FullHouse(), new FiveOfAKind()})
        {
            if (appleSauce.Matches(scoringType))
            {
                return appleSauce.GetScore(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }
}