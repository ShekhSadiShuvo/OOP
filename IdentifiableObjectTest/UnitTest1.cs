using CaseStudy;

namespace IdentifiableObjectTest
{
    [TestFixture]
    public class IdentifiableObjectTests
    {
        private IdentifiableObject _testObject;

        private string[] _testArray;

        private IdentifiableObject _emptyObject;

        private string[] _emptyArray;

        [SetUp]
        public void Setup()
        {

            _testArray = new string[] { "fred", "bob" };
            _testObject = new IdentifiableObject(_testArray);


            _emptyArray = new string[] { };
            _emptyObject = new IdentifiableObject(_emptyArray);
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(_testObject.AreYou("fred"));
            Assert.IsTrue(_testObject.AreYou("bob"));

        }
        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(_testObject.AreYou("wilma"));
            Assert.IsFalse(_testObject.AreYou("boby"));
        }

        [Test]
        public void TestInsensitive()
        {
            Assert.IsTrue(_testObject.AreYou("FRED"));
            Assert.IsTrue(_testObject.AreYou("bOB"));
        }

        [Test]
        public void TestFirstID()
        {
            Assert.That(_testObject.FirstID, Is.EqualTo("fred"));
        }

        [Test]
        public void TestFirstIDWithNoIDs()
        {
            Assert.That(_emptyObject.FirstID, Is.EqualTo(""));
        }

        [Test]
        public void TestAddID()
        {
            _testObject.AddIdentifier("wilma");
            Assert.IsTrue(_testObject.AreYou("fred"));
            Assert.IsTrue(_testObject.AreYou("bob"));
            Assert.IsTrue(_testObject.AreYou("wilma"));
        }
    }

}