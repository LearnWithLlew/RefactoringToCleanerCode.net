using System.Linq;

namespace Yatzy
{
    public static class Yatzy
    {
        public static int GetScore(ScoringType scoringType, int d1, int d2, int d3, int d4, int d5)
        {
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
                case ScoringType.Ones:
                {
                    var sum = 0;
                    if (d1 == 1) sum++;
                    if (d2 == 1) sum++;
                    if (d3 == 1) sum++;
                    if (d4 == 1) sum++;
                    if (d5 == 1)
                        sum++;

                    return sum;
                }
                case ScoringType.Twos:
                {
                    var sum1 = 0;
                    if (d1 == 2) sum1 += 2;
                    if (d2 == 2) sum1 += 2;
                    if (d3 == 2) sum1 += 2;
                    if (d4 == 2) sum1 += 2;
                    if (d5 == 2) sum1 += 2;
                    return sum1;
                }
                case ScoringType.Threes:
                {
                    int s;
                    s = 0;
                    if (d1 == 3) s += 3;
                    if (d2 == 3) s += 3;
                    if (d3 == 3) s += 3;
                    if (d4 == 3) s += 3;
                    if (d5 == 3) s += 3;
                    return s;
                }
                case ScoringType.Pair:
                {
                    var counts = new int[6];
                    counts[d1 - 1]++;
                    counts[d2 - 1]++;
                    counts[d3 - 1]++;
                    counts[d4 - 1]++;
                    counts[d5 - 1]++;
                    int at;
                    for (at = 0; at != 6; at++)
                        if (counts[6 - at - 1] >= 2)
                            return (6 - at) * 2;
                    return 0;
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
                            return 50;
                    return 0;
                }
                case ScoringType.FourOfAKind:
                {
                    int[] tallies1;
                    tallies1 = new int[6];
                    tallies1[d1 - 1]++;
                    tallies1[d2 - 1]++;
                    tallies1[d3 - 1]++;
                    tallies1[d4 - 1]++;
                    tallies1[d5 - 1]++;
                    for (var i1 = 0; i1 < 6; i1++)
                        if (tallies1[i1] >= 4)
                            return (i1 + 1) * 4;
                    return 0;
                }
                case ScoringType.ThreeOfAKind:
                {
                    int[] t;
                    t = new int[6];
                    t[d1 - 1]++;
                    t[d2 - 1]++;
                    t[d3 - 1]++;
                    t[d4 - 1]++;
                    t[d5 - 1]++;
                    for (var i1 = 0; i1 < 6; i1++)
                        if (t[i1] >= 3)
                            return (i1 + 1) * 3;
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
                case ScoringType.Fours:
                {
                    int[] dice = new[] {d1, d2, d3, d4, d5};
                    int sum2;
                    sum2 = 0;
                    for (var at1 = 0; at1 != 5; at1++)
                        if (dice[at1] == 4)
                            sum2 += 4;
                    return sum2;
                }
                case ScoringType.Fives:
                {
                    int[] dice = new[] {d1, d2, d3, d4, d5};
                    var s1 = 0;
                    int i1;
                    for (i1 = 0; i1 < dice.Length; i1++)
                        if (dice[i1] == 5)
                            s1 = s1 + 5;
                    return s1;
                }
                case ScoringType.Sixes:
                {
                    int[] dice = new[] {d1, d2, d3, d4, d5};
                    return dice.Where(d => d == 6).Sum();
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