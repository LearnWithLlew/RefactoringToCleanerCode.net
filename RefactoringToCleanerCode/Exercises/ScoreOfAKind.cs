using System.Collections.Generic;
using Yatzy;

class ScoreOfAKind : IScorer
{
    public bool IsRelevant(ScoringType scoringType)
    {
        return scoringType == ScoringType.FourOfAKind || scoringType == ScoringType.Pair ||
               scoringType == ScoringType.ThreeOfAKind;
    }

    public int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        var value = new Dictionary<ScoringType, int>
        {
            {ScoringType.Pair, 2},
            {ScoringType.FourOfAKind, 4},
            {ScoringType.ThreeOfAKind, 3},
        }[scoringType];
        int[] tallies1;
        tallies1 = new int[6];
        tallies1[die1 - 1]++;
        tallies1[die2 - 1]++;
        tallies1[die3 - 1]++;
        tallies1[die4 - 1]++;
        tallies1[die5 - 1]++;
        for (int i = 6 - 1; i >= 0; i--)
        {
            if (tallies1[i] >= value)
                return (i + 1) * value;
        }

        return 0;
    }
}