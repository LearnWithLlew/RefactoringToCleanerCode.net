public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int d3, int dice4, int fifthDie)
    {
        const int bigScore = 50;
        switch (scoringType)
        {
            case ScoringType.Pair:
            {
                const int value = 2;
                int[] tallies1;
                tallies1 = new int[6];
                tallies1[dieOne - 1]++;
                tallies1[dieTwo - 1]++;
                tallies1[d3 - 1]++;
                tallies1[dice4 - 1]++;
                tallies1[fifthDie - 1]++;
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
                counts1[dieOne - 1]++;
                counts1[dieTwo - 1]++;
                counts1[d3 - 1]++;
                counts1[dice4 - 1]++;
                counts1[fifthDie - 1]++;
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
                int[] tallies;
                var _2 = false;
                int i;
                var _2_at = 0;
                var _3 = false;
                var _3_at = 0;


                tallies = new int[6];
                tallies[dieOne - 1] += 1;
                tallies[dieTwo - 1] += 1;
                tallies[d3 - 1] += 1;
                tallies[dice4 - 1] += 1;
                tallies[fifthDie - 1] += 1;

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

            case ScoringType.FiveOfAKind:
            {
                int[] dice1 = {dieOne, dieTwo, d3, dice4, fifthDie};
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

        return 0;
    }
}