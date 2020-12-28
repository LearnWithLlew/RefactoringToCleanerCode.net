using System;
using System.Collections.Generic;
using System.Linq;

namespace Yatzy
{
    public static class Yatzy
    {
        public static int GetScore(ScoringType scoringType, int d1, int d2, int d3, int d4, int d5)
        {
            const int bigScore = 50;
            switch (scoringType)
            {
                case ScoringType.Chance:
                {
                    var total = 0;
                    total += d1;
                    total += d2;
                    total += d3;
                    total += d4;
                    total += d5;
                    return total;
                }
                case ScoringType.TwoPair:
                {
                    var counts1 = new int[6];
                    counts1[d1 - 1]++;
                    counts1[d2 - 1]++;
                    counts1[d3 - 1]++;
                    counts1[d4 - 1]++;
                    counts1[d5 - 1]++;
                    var n = 0;
                    var score = 0;
                    for (var i = 0; i < 6; i += 1)
                        if (counts1[6 - i - 1] >= 2)
                        {
                            n++;
                            score += 6 - i;
                        }

                    if (n == 2)
                        return score * 2;
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
                    tallies[d1 - 1] += 1;
                    tallies[d2 - 1] += 1;
                    tallies[d3 - 1] += 1;
                    tallies[d4 - 1] += 1;
                    tallies[d5 - 1] += 1;

                    for (i = 0; i != 6; i += 1)
                        if (tallies[i] == 2)
                        {
                            _2 = true;
                            _2_at = i + 1;
                        }

                    for (i = 0; i != 6; i += 1)
                        if (tallies[i] == 3)
                        {
                            _3 = true;
                            _3_at = i + 1;
                        }

                    if (_2 && _3)
                        return _2_at * 2 + _3_at * 3;
                    return 0;
                }
                case ScoringType.Yatzy:
                {
                    int[] dice1 = new[] {d1, d2, d3, d4, d5};
                    var counts2 = new int[6];
                    foreach (var die in dice1)
                        counts2[die - 1]++;
                    for (var i1 = 0; i1 != 6; i1++)
                        if (counts2[i1] == 5)
                        {
                            return bigScore;
                        }

                    return 0;
                }
                case ScoringType.SmallStraight:
                {
                    int[] tallies2;
                    tallies2 = new int[6];
                    tallies2[d1 - 1] += 1;
                    tallies2[d2 - 1] += 1;
                    tallies2[d3 - 1] += 1;
                    tallies2[d4 - 1] += 1;
                    tallies2[d5 - 1] += 1;
                    if (tallies2[0] == 1 &&
                        tallies2[1] == 1 &&
                        tallies2[2] == 1 &&
                        tallies2[3] == 1 &&
                        tallies2[4] == 1)
                        return 15;
                    return 0;
                }
                case ScoringType.LargeStraight:
                {
                    int[] tallies3;
                    tallies3 = new int[6];
                    tallies3[d1 - 1] += 1;
                    tallies3[d2 - 1] += 1;
                    tallies3[d3 - 1] += 1;
                    tallies3[d4 - 1] += 1;
                    tallies3[d5 - 1] += 1;
                    if (tallies3[1] == 1 &&
                        tallies3[2] == 1 &&
                        tallies3[3] == 1 &&
                        tallies3[4] == 1
                        && tallies3[5] == 1)
                        return 20;
                    return 0;
                }
                case ScoringType.Ones:
                case ScoringType.Twos:
                case ScoringType.Threes:
                case ScoringType.Fours:
                case ScoringType.Fives:
                case ScoringType.Sixes:
                {
                    var value = new Dictionary<ScoringType, int>
                    {
                        {ScoringType.Ones, 1},
                        {ScoringType.Twos, 2},
                        {ScoringType.Threes, 3},
                        {ScoringType.Fours, 4},
                        {ScoringType.Fives, 5},
                        {ScoringType.Sixes, 6},
                    }[scoringType];
                    ;
                    int s;
                    s = 0;
                    if (d1 == value) s += value;
                    if (d2 == value) s += value;
                    if (d3 == value) s += value;
                    if (d4 == value) s += value;
                    if (d5 == value) s += value;
                    return s;
                }
                case ScoringType.FourOfAKind:
                case ScoringType.Pair:
                case ScoringType.ThreeOfAKind:
                {
                    var value = new Dictionary<ScoringType, int>
                    {
                        {ScoringType.Pair, 2},
                        {ScoringType.FourOfAKind, 4},
                        {ScoringType.ThreeOfAKind, 3},
                    }[scoringType];
                    int[] tallies1;
                    tallies1 = new int[6];
                    tallies1[d1 - 1]++;
                    tallies1[d2 - 1]++;
                    tallies1[d3 - 1]++;
                    tallies1[d4 - 1]++;
                    tallies1[d5 - 1]++;
                    for (int i = 6 - 1; i >= 0; i--)
                    {
                        if (tallies1[i] >= value)
                            return (i + 1) * value;
                    }

                    return 0;
                }
            }

            return 0;
        }
    }

    public enum ScoringType
    {
        Chance,

        Ones,
        Twos,
        Threes,

        Pair,
        TwoPair,
        FullHouse,
        FourOfAKind,
        ThreeOfAKind,

        SmallStraight,
        LargeStraight,

        Fours,
        Sixes,
        Fives,

        Yatzy,
    }
}