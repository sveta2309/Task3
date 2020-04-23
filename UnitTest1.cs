using NUnit.Framework;
using System;
using HW3;
using System.IO;

namespace CalcTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1, 5, -4)]

        public void TestFirstActionMethod(double a, double b, double expRes)
        {
            double actRes = new Calc().FirstAction(a,b);
            Assert.AreEqual(expRes, actRes);
        }
        [TestCase(-4, 16)]

        public void TestSecondActionMethod(double a, double expRes)
        {
            double actRes = new Calc().SecondAction(a);
            Assert.AreEqual(expRes, actRes);
        }
        [TestCase(2,16,0.125)]

        public void TestThirdtActionMethod(double a, double b, double expRes)
        {
            double actRes = new Calc().ThirdAction(a, b);
            Assert.AreEqual(expRes, actRes);
        }
        [TestCase(4, 0.125, 0.5)]

        public void TestForthActionMethod(double a, double b, double expRes)
        {
            double actRes = new Calc().ForthAction(a, b);
            Assert.AreEqual(expRes, actRes);
        }
        [TestCase(3, 0.5, 3.5)]

        public void TestFifthActionMethod(double a, double b, double expRes)
        {
            double actRes = new Calc().FifthAction(a, b);
            Assert.AreEqual(expRes, actRes);
        }
        [TestCase("3 4 2 1 5", 3.5)]
        public void TestCalcMethod(string s, double expRes)
        {
            double actRes = new Calc().Calculation(s);
            Assert.AreEqual(expRes, actRes);
        }
        [Test]
        public void TestAskNumbersMethod()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                new Menu().AskNumbers();

                var result = sw.ToString().Trim();
                Assert.AreEqual("Enter numbers via space", result);
            }

        }
        [Test]
        public void TestReadNumbersMethod()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("");
            Console.SetIn(input);
            Assert.That(output.ToString(),Is.Empty,Environment.NewLine);
        }
    }
}
