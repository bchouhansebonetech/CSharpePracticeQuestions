using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticePrograms;
namespace PracticeProgramTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsPrime()
        {
            CheckingPrime checkingPrime = new CheckingPrime();
            Assert.AreEqual(true,checkingPrime.isPrime(7));
            Assert.AreEqual(false, checkingPrime.isPrime(8));
        }

        [TestMethod]
        public void TestIsAnagram()
        {
            AnagramStrings anagramStrings = new AnagramStrings();
            Assert.AreEqual(true, anagramStrings.isAnagram("bhanu", "hanub"));
            Assert.AreEqual(false, anagramStrings.isAnagram("bhnue", "hanub"));
            Assert.AreEqual(false, anagramStrings.isAnagram("bhnu", "hanub"));
        }

        [TestMethod]
        public void TestGetSumOnetoN()
        {
            SumOfNNumbers sumOfNNumbers = new SumOfNNumbers();
            Assert.AreEqual(55, sumOfNNumbers.getSumOnetoN(10));
            Assert.AreEqual(0, sumOfNNumbers.getSumOnetoN(0));
        }

        [TestMethod]
        public void TestGetFactorialOfNumber()
        {
            FactorialOfNumber factorialOfNumber = new FactorialOfNumber();
            Assert.AreEqual(120, factorialOfNumber.getFactorialOfNumber(5));
            Assert.AreEqual(1, factorialOfNumber.getFactorialOfNumber(0));
        }

        [TestMethod]
        public void TestIsTargetSumAvailable()
        {
            TwoSumProblem twoSumProblem = new TwoSumProblem();
            int[] nums = { 5, 8, 3, 4, 5, 4 };
            int k = 9;
            Assert.AreEqual(true, twoSumProblem.isTargetSumAvailable(nums, k));
            Assert.AreEqual(false, twoSumProblem.isTargetSumAvailable(nums, 15));
        }

        [TestMethod]
        public void TestGetReversedString()
        {
            StringReverse stringReverse = new StringReverse();
            Assert.AreEqual("abc", stringReverse.getReversedString("cba"));
            Assert.AreEqual("bhanu", stringReverse.getReversedString("unahb"));
        }

    }
}