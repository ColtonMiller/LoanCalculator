using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LoanCalculator
{
    [TestFixture]
    class Test
    {
        [Test]
        public void SerialTest()
        {
            SerialLoan testLoan = new SerialLoan(10000, 0.02, 10);
            Assert.IsTrue(testLoan.Interest(5) == 120);

        }

        [Test]
        public void AnnuityTest()
        {
            AnnuityLoan testLoan = new AnnuityLoan(10000, 0.02, 10);
            Assert.IsTrue(Math.Round(testLoan.Interest(5),2) == 124.72);

        }
    }
}
