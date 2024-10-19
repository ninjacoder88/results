
namespace Ninjasoft.Results.UnitTests
{
    internal sealed class FailureTests
    {
        [Test]
        public void DefaultConstructor_IsSuccess_IsFalse()
        {
            var result = new Failure();
            Assert.That(result.IsSuccess, Is.False); 
        }

        [Test]
        public void DefaultConstructor_ErrorMessage_IsNull()
        {
            var result = new Failure();
            Assert.That(result.ErrorMessage, Is.Null);
        }

        [Test]
        public void MessageConstructor_IsSuccess_IsFalse()
        {
            var result = new Failure("Any text");
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void MessageConstructor_ErrorMessage_IsNotNull()
        {
            var result = new Failure("Any text");
            Assert.That(result.ErrorMessage, Is.EqualTo("Any text"));
        }


        [Test]
        public void ResultConstructorWithFailure_IsSuccess_IsFalse()
        {
            var r = new Failure("Some text");
            var result = new Failure(r);
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void ResultConstructorWithFailure_ErrorMessage_IsNotNull()
        {
            var r = new Failure("Some text");
            var result = new Failure(r);
            Assert.That(result.ErrorMessage, Is.EqualTo("Some text"));
        }

        [Test]
        public void ResultConstructorWithFailure_ErrorMessage_IsNullIfFailureIsNull()
        {
            var r = new Failure();
            var result = new Failure(r);
            Assert.That(result.ErrorMessage, Is.Null);
        }
    }
}
