public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        if (Pair.IsStuff(st))
        {
            return Pair.Stuff(die1, die2, die3, die4, die5);
        }

        if (TwoPair.IsStuff2(st))
        {
            return TwoPair.Stuff2(die1, die2, die3, die4, die5);
        }

        if (FullHouse.IsStuff3(st))
        {
            return FullHouse.stuff3(die1, die2, die3, die4, die5);
        }

        if (FiveOfAKind.IsStuff4(st))
        {
            return FiveOfAKind.Stuff4(die1, die2, die3, die4, die5);
        }

        return 0;
    }
}