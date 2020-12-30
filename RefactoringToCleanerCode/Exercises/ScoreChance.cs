using Yatzy;

public interface IScorer
{
    bool IsRelevant(ScoringType scoringType);
    int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5);
}

internal class ScoreChance : IScorer
{
    public bool IsRelevant(ScoringType scoringType)
    {
        return scoringType == ScoringType.Chance;
    }

    public int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        var total = 0;
        total += die1;
        total += die2;
        total += die3;
        total += die4;
        total += die5;
        return total;
    }
}