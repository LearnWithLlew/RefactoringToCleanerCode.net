using System;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [UseReporter(typeof(DiffReporter))]
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dice = new[] {1, 2, 3, 4, 5, 6};
            CombinationApprovals.VerifyAllCombinations(
                (a, b, c, d, e, f) => BigDiceGame.GetScore(a, b, c, d, e, f),
                (ScoringType[]) Enum.GetValues(typeof(ScoringType)), dice, dice, dice, dice, dice);
        }
    }
}