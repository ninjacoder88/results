namespace Ninjasoft.Results.UnitTests
{
    [TestFixture]
    internal sealed class GenericSuccessTests
    {
        [Test]
        public void IsSuccess_IsTrue()
        {
            var result = new Success<SuccessItem>(new SuccessItem());
            Assert.That(result.IsSuccess, Is.True);
        }

        [Test]
        public void ErrorMessage_IsNull()
        {
            var result = new Success<SuccessItem>(new SuccessItem());
            Assert.That(result.ErrorMessage, Is.Null);
        }

        [Test]
        public void Data_IsNotNull()
        {
            var result = new Success<SuccessItem>(new SuccessItem());
            Assert.That(result.Data, Is.Not.Null);
        }
    }

    public class SuccessItem
    {
        public int Id { get; set; }
    }
}
