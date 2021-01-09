public static class BigDiceGame
{
    public static int GetScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        switch (st)
        {
            case ScoringType.Pair:
            {
                return Pair.Applesauce(die1, die2, die3, die4, die5);
            }

            case ScoringType.TwoPair:
            {
                return TwoPair.AppleSauce2(die1, die2, die3, die4, die5);
            }

            case ScoringType.FullHouse:
            {
                return FullHouse.AppleSauce3(die1, die2, die3, die4, die5);
            }

            case ScoringType.FiveOfAKind:
            {
                return FiveOfAKind.AppleSauce4(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }
}