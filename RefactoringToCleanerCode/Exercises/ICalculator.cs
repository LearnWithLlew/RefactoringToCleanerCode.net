internal interface ICalculator
{
    int Calculate(int die1, int die2, int d3, int dieFour, int fifthDie);
    bool IsSupported(ScoringType st);
}