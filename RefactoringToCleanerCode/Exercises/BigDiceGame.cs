﻿public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        switch (st)
        {
            case ScoringType.Pair:
            {
                return SomeFunction4(die1, die2, die3, die4, die5);
            }

            case ScoringType.TwoPair:
            {
                return TwoPairScore.SomeFunction3(die1, die2, die3, die4, die5);
            }

            case ScoringType.FullHouse:
            {
                return FullHouseScore.Evaluate(die1, die2, die3, die4, die5);
            }

            case ScoringType.FiveOfAKind:
            {
                return FiveOfKindScore.Evaluate(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }

    private static int SomeFunction4(int die1, int die2, int die3, int die4, int die5)
    {
        const int value = 2;
        int[] tallies1;
        tallies1 = new int[6];
        tallies1[die1 - 1]++;
        tallies1[die2 - 1]++;
        tallies1[die3 - 1]++;
        tallies1[die4 - 1]++;
        tallies1[die5 - 1]++;
        for (var i = 6 - 1; i >= 0; i--)
        {
            if (tallies1[i] >= value)
            {
                return (i + 1) * value;
            }
        }

        return 0;
    }
}