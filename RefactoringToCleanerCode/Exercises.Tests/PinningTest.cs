using System;
using System.Linq;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [UseReporter(typeof(DiffReporter))]
    [TestClass]
    public class PinningTest
    {
        [TestMethod]
        public void PinEverything()
        {
            var dice = new[] {1, 2, 3, 4, 5, 6};
            var scoringTypes = Enum.GetValues(typeof(ScoringType)).Cast<ScoringType>().Append((ScoringType) (-1));
            CombinationApprovals.VerifyAllCombinations(
                (a, b, c, d, e, f) => BigDiceGame.GetScore(a, b, c, d, e, f),
                scoringTypes, dice, dice, dice, dice, dice);
        }
    }
}