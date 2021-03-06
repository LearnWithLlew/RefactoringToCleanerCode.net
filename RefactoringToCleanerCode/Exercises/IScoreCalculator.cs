internal interface IScoreCalculator
{
    int CalculateScore(int die1, int die2, int die3, int die4, int die5);
    bool IsApplicable(ScoringType st);
}