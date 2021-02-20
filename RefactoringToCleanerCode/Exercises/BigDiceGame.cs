public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        if (IsStuff(st))
        {
            return Pair.Stuff(die1, die2, die3, die4, die5);
        }

        if (IsStuff2(st))
        {
            return TwoPair.Stuff2(die1, die2, die3, die4, die5);
        }

        if (IsStuff3(st))
        {
            return FullHouse.stuff3(die1, die2, die3, die4, die5);
        }

        if (IsStuff4(st))
        {
            return FiveOfAKind.Stuff4(die1, die2, die3, die4, die5);
        }

        return 0;
    }

    private static bool IsStuff4(ScoringType st)
    {
        return st == ScoringType.FiveOfAKind;
    }

    private static bool IsStuff3(ScoringType st)
    {
        return st == ScoringType.FullHouse;
    }

    private static bool IsStuff2(ScoringType st)
    {
        return st == ScoringType.TwoPair;
    }

    private static bool IsStuff(ScoringType st)
    {
        return st == ScoringType.Pair;
    }
}