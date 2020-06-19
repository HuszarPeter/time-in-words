using NUnit.Framework;
using TimeInWords;

namespace TimeInWordsTests
{
    public class TimeToWordsServiceTests
    {
        private readonly TimeToWordsService timeToWordsService = new TimeToWordsService();

        [Test]
        public void TestOne()
        {
            var result = timeToWordsService.ConvertTime(5,30);
            Assert.AreEqual("half past five", result);
        }
        
        [Test]
        public void TestTwo()
        {
            var result = timeToWordsService.ConvertTime(5,00);
            Assert.AreEqual("five o' clock", result);
        }
        
        [Test]
        public void TestThree()
        {
            var result = timeToWordsService.ConvertTime(5,15);
            Assert.AreEqual("quarter past five", result);
        }
        
        [Test]
        public void TestFour()
        {
            var result = timeToWordsService.ConvertTime(5,45);
            Assert.AreEqual("quarter to six", result);
        }
        
        [Test]
        public void TestFive()
        {
            var result = timeToWordsService.ConvertTime(5,01);
            Assert.AreEqual("one minute past five", result);
        }
        
        [Test]
        public void TestSix()
        {
            var result = timeToWordsService.ConvertTime(21,01);
            Assert.AreEqual("one minute past nine", result);
        }
        
        [Test]
        public void TestSeven()
        {
            var result = timeToWordsService.ConvertTime(21,36);
            Assert.AreEqual("twenty four minutes to ten", result);
        }
        
        [Test]
        public void TestEight()
        {
            var result = timeToWordsService.ConvertTime(21,22);
            Assert.AreEqual("twenty two minutes past nine", result);
        }
        
        [Test]
        public void TestNine()
        {
            var result = timeToWordsService.ConvertTime(21,12);
            Assert.AreEqual("twelve minutes past nine", result);
        }
    }
}