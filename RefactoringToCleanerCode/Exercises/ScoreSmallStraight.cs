using Yatzy;

class ScoreSmallStraight : IScorer
{
    public bool IsRelevant(ScoringType scoringType)
    {
        return scoringType == ScoringType.SmallStraight;
    }

    public int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        int[] tallies2;
        tallies2 = new int[6];
        tallies2[die1 - 1] += 1;
        tallies2[die2 - 1] += 1;
        tallies2[die3 - 1] += 1;
        tallies2[die4 - 1] += 1;
        tallies2[die5 - 1] += 1;
        if (tallies2[0] == 1 &&
            tallies2[1] == 1 &&
            tallies2[2] == 1 &&
            tallies2[3] == 1 &&
            tallies2[4] == 1)
            return 15;
        return 0;
    }
}