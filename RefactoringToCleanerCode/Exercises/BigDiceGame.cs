﻿public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        if (new Pair().IsScorable(st))
        {
            return new Pair().CalculateScore(die1, die2, die3, die4, die5);
        }

        if (new TwoPair().IsStuff2(st))
        {
            return new TwoPair().Stuff2(die1, die2, die3, die4, die5);
        }

        if (new FullHouse().IsStuff3(st))
        {
            return new FullHouse().stuff3(die1, die2, die3, die4, die5);
        }

        if (new FiveOfAKind().IsStuff4(st))
        {
            return new FiveOfAKind().Stuff4(die1, die2, die3, die4, die5);
        }

        return 0;
    }
}