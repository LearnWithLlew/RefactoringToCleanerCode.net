public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        const int bigScore = 50;
        switch (st)
        {
            case ScoringType.Pair:
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

            case ScoringType.TwoPair:
            {
                var counts1 = new int[6];
                counts1[die1 - 1]++;
                counts1[die2 - 1]++;
                counts1[die3 - 1]++;
                counts1[die4 - 1]++;
                counts1[die5 - 1]++;
                var n = 0;
                var score = 0;
                for (var i = 0; i < 6; i += 1)
                {
                    if (counts1[6 - i - 1] >= 2)
                    {
                        n++;
                        score += 6 - i;
                    }
                }

                if (n == 2)
                {
                    return score * 2;
                }

                return 0;
            }

            case ScoringType.FullHouse:
            {
                return SomeFunction2(die1, die2, die3, die4, die5);
            }

            case ScoringType.FiveOfAKind:
            {
                return SomeFunction(die1, die2, die3, die4, die5, bigScore);
            }
        }

        return 0;
    }

    private static int SomeFunction2(int die1, int die2, int die3, int die4, int die5)
    {
        int[] tallies;
        var _2 = false;
        int i;
        var _2_at = 0;
        var _3 = false;
        var _3_at = 0;


        tallies = new int[6];
        tallies[die1 - 1] += 1;
        tallies[die2 - 1] += 1;
        tallies[die3 - 1] += 1;
        tallies[die4 - 1] += 1;
        tallies[die5 - 1] += 1;

        for (i = 0; i != 6; i += 1)
        {
            if (tallies[i] == 2)
            {
                _2 = true;
                _2_at = i + 1;
            }
        }

        for (i = 0; i != 6; i += 1)
        {
            if (tallies[i] == 3)
            {
                _3 = true;
                _3_at = i + 1;
            }
        }

        if (_2 && _3)
        {
            return _2_at * 2 + _3_at * 3;
        }

        return 0;
    }

    private static int SomeFunction(int die1, int die2, int die3, int die4, int die5, int bigScore)
    {
        int[] dice1 = {die1, die2, die3, die4, die5};
        var counts2 = new int[6];
        foreach (var die in dice1)
        {
            counts2[die - 1]++;
        }

        for (var i1 = 0; i1 != 6; i1++)
        {
            if (counts2[i1] == 5)
            {
                return bigScore;
            }
        }

        return 0;
    }
}