using System.Collections.Generic;
using Yatzy;

class ScoreNumber : IScorer
{
    public bool IsRelevant(ScoringType scoringType)
    {
        return scoringType == ScoringType.Ones || scoringType == ScoringType.Twos ||
               scoringType == ScoringType.Threes || scoringType == ScoringType.Fours ||
               scoringType == ScoringType.Fives || scoringType == ScoringType.Sixes;
    }

    public int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
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
        if (die1 == value) s += value;
        if (die2 == value) s += value;
        if (die3 == value) s += value;
        if (die4 == value) s += value;
        if (die5 == value) s += value;
        return s;
    }
}