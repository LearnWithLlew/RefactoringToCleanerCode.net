using System;
using System.Collections.Generic;
using ApprovalTests.Combinations;

internal static class Utilities
{
    public static void VerifyAllCombinations<T1, T2, T3, T4, T5, T6, TResult>(
        Func<T1, T2, T3, T4, T5, T6, TResult> processCall,
        IEnumerable<T1> aList, IEnumerable<T2> bList, IEnumerable<T3> cList, IEnumerable<T4> dList,
        IEnumerable<T5> eList,
        IEnumerable<T6> fList)
    {
        CombinationApprovals.VerifyAllCombinations((a, b, c, d, e, f) => processCall(a, b, c, d, e, f), aList, bList,
            cList, dList, eList, fList);
    }
}
