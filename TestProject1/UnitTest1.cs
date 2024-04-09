using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using MyFuncLib;

namespace MyFunc.Tests
{

    public class TestFactorial
    {
        [TestCase(10, 3628800)]
        [TestCase(5, 120)]
        [TestCase(25, 7034535277573963776)]
        [TestCase(9, 362880)]
        public void FactorialTest(int example, long ans)
        {
            Assert.AreEqual(ans, Functions.Factorial(example));
        }

    }

    public class TestCosTaylor
    {
        [TestCase(0.995004, 0.1)]
        [TestCase(0.995004, -0.1)]
        [TestCase(-0.653644, 4)]
        [TestCase(-0.653644, -4)]
        [TestCase(-1, -5)]
        [TestCase(-1, 100)]
        public void SimpleTest(double result, double x)
        {
            Assert.That(Functions.CosTaylor(x), Is.EqualTo(result).Within(0.0001));
        }
    }

    public class TestSinTaylor
    {
        [TestCase(0.0998334, 0.1)]
        [TestCase(-0.0998334, -0.1)]
        [TestCase(-0.756802, 4)]
        [TestCase(0.756802, -4)]
        [TestCase(-1, -6)]
        [TestCase(-1, 100)]
        public void SimpleTest(double result, double x)
        {
            Assert.That(Functions.SinTaylor(x), Is.EqualTo(result).Within(0.0001));
        }
    }

    public class TestLogTaylor
    {

        [TestCase(-2.30259, 0.1)]
        [TestCase(0.641854, 1.9)]
        [TestCase(-1, 5)]
        [TestCase(-1, -3)]
        public void SimpleTest(double result, double x)
        {
            Assert.That(Functions.LogTaylor(x), Is.EqualTo(result).Within(0.0001));
        }
    }

    public class TestfirstStmt
    {
        [TestCase(-0.8284, -1)]
        [TestCase(0.005618, -0.1)]
        [TestCase(0.677802, -0.52)]
        [TestCase(-1.33608, -0.723)]
        public void SimpleTest(double result, double x)
        {
            Assert.That(Functions.firststmt(x), Is.EqualTo(result).Within(0.001));
        }
    }

    public class TestsecondStmt
    {
        [TestCase(1.284, 1.111)]
        [TestCase(1.414, 1)]
        [TestCase(2.43485, 0.52)]
        [TestCase(1.18850, 1.21)]
        public void SimpleTest(double result, double x)
        {
            Assert.That(Functions.secondstmt(x), Is.EqualTo(result).Within(0.001));
        }
    }

    public class IntegrTest
    {
        [TestCase(1.284, 1.111)]
        [TestCase(1.414, 1)]
        [TestCase(0.677802, -0.52)]
        [TestCase(-1.33608, -0.723)]
        public void SimpleTest(double result, double x)
        {
            Assert.That(Functions.MainFunc(x), Is.EqualTo(result).Within(0.001));
        }
    }

}
