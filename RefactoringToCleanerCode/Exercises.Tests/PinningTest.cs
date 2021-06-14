using System.Linq;
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

            var scoringTypes = Enum.GetValues<ScoringType>().Append((ScoringType) (-1));

            Utilities.VerifyAllCombinations(
                BigDiceGame.CalculateScore,
                scoringTypes,
                dice,
                dice,
                dice,
                dice,
                dice
            t);
        }
    }
}
