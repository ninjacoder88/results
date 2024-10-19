namespace Ninjasoft.Results.UnitTests
{
    [TestFixture]
    internal sealed class SuccessTests
    {
        [Test]
        public void IsSuccess_IsTrue()
        {
            var result = new Success();
            Assert.That(result.IsSuccess, Is.True);
        }

        [Test]
        public void ErrorMessage_IsNull()
        {
            var result = new Success();
            Assert.That(result.ErrorMessage, Is.Null);
        }
    }
}
