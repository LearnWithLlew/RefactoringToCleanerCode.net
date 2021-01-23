static internal class CalculateFullHouseScore
{
    public static int Calculate(int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        int[] tallies;
        var _2 = false;
        int i;
        var _2_at = 0;
        var _3 = false;
        var _3_at = 0;


        tallies = new int[6];
        tallies[dieOne - 1] += 1;
        tallies[dieTwo - 1] += 1;
        tallies[dieThree - 1] += 1;
        tallies[dieFour - 1] += 1;
        tallies[dieFive - 1] += 1;

        for (i = 0; i != 6; i += 1)
        {
            if (tallies[i] == 2)
            {
                _2 = true;
                _2_at = i + 1;
            }
        }

        for (i = 0; i != 6; i += 1)
        {
            if (tallies[i] == 3)
            {
                _3 = true;
                _3_at = i + 1;
            }
        }

        if (_2 && _3)
        {
            return _2_at * 2 + _3_at * 3;
        }

        return 0;
    }

    public static bool Nonsense3(ScoringType scoringType)
    {
        return scoringType == ScoringType.FullHouse;
    }
}