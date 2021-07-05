using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System; 
namespace Kata06_Anagrams
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TimeTestThatReturn2seconds()
        {
            var instance = new Anagram();

            TimeSpan result = instance.Read(@"../wordlist.txt");
            TestTime Test = new TimeSpan(0, 0, 0, 2);
            Assert.IsTrue(TimeSpan.Compare(result, Test) < 1);
        }

         [TestMethod]
        public void NumberOfWords()
        {
            var instance = new Program.Anagram();
            instance.Read(@"../wordlist.txt");
            Assert.AreEqual(20683, instance.Index.Count);
        }
    }
}
