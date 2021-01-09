public static class BigDiceGame
{
    public static int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        if (scoringType == ScoringType.Pair)
        {
            return Pair.Applesauce(die1, die2, die3, die4, die5);
        }

        if (scoringType == ScoringType.TwoPair)
        {
            return TwoPair.AppleSauce2(die1, die2, die3, die4, die5);
        }

        if (scoringType == ScoringType.FullHouse)
        {
            return FullHouse.AppleSauce3(die1, die2, die3, die4, die5);
        }

        if (scoringType == ScoringType.FiveOfAKind)
        {
            return FiveOfAKind.AppleSauce4(die1, die2, die3, die4, die5);
        }

        return 0;
    }
}