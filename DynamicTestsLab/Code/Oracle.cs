using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTestsLab
{
    class Oracle
    {
        public static double OracleResult(TestCaseParameters testCase) {
            double resultOfOracul = 0;
            for (int i = 0; i < testCase.Polynoms.Count(); i++)
                resultOfOracul += testCase.Polynoms[i] * ((Math.Pow((double)testCase.RightBorder, i + 1) / (i + 1)) - (Math.Pow((double)testCase.LeftBorder, i + 1) / (i + 1)));
            return resultOfOracul;
        }
    }
}
