using Yatzy;

class ScoreLargeStraight : IScorer
{
    public bool IsRelevant(ScoringType scoringType)
    {
        return scoringType == ScoringType.LargeStraight;
    }

    public int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        int[] tallies3;
        tallies3 = new int[6];
        tallies3[die1 - 1] += 1;
        tallies3[die2 - 1] += 1;
        tallies3[die3 - 1] += 1;
        tallies3[die4 - 1] += 1;
        tallies3[die5 - 1] += 1;
        if (tallies3[1] == 1 &&
            tallies3[2] == 1 &&
            tallies3[3] == 1 &&
            tallies3[4] == 1
            && tallies3[5] == 1)
            return 20;
        return 0;
    }
}