using Microsoft.VisualBasic;
using NUnit.Framework.Internal;
using NunitTesting;


using System;
using System.Collections.Generic;
using NUnit.Framework; 

namespace NunitTesting 
{
    [TestFixture]
    public class UnitTest1 
    {
        private object _testableObject;
        private string _testableString;

        [SetUp]
        public void SetUp()
        {
            _testableObject = new object();
            _testableString = "Some string.";
        }

        [Test]
        public void TestObjectExists()
        {
            Assert.IsNotNull(_testableObject); 
           
            Assert.AreEqual
            ("Some string.", _testableString, "Testing that the string matches, including the case" );
           
        }
        
        [TestCase("Some string.")]
                [TestCase("SOME sTrInG.")] 
        [TestCase("some string.")]
        public void TestString(string toTest)
        {
            StringAssert.AreEqualIgnoringCase(toTest, _testableString, "Testing the strings are actually the same.");

}
    }
}
