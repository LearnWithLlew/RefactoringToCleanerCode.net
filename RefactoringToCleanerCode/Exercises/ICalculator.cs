internal interface ICalculator
{
    int Calculate(int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive);
    bool ShouldCalculate(ScoringType scoringType);
}