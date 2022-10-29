using NUnit.Framework;

namespace Tests2
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test()
        {
            string asd = deployment_test.Program.Print();
            Assert.AreEqual(asd, "asd");
        }
    }
}