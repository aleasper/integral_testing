using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTestsLab
{
    class TestCaseParameters
    {
        public decimal LeftBorder { get; set; }
        public decimal RightBorder { get; set; }
        public decimal Step { get; set; }

        public List<double> Polynoms = new List<double>();
    }
}
