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
                (a, b, c, d, e, f) =>  Yatzy.Yatzy.GetScore(a, b, c, d, e, f),
                (Yatzy.ScoringType[]) Enum.GetValues(typeof(Yatzy.ScoringType)), dice, dice, dice, dice, dice);
        }
    }
}