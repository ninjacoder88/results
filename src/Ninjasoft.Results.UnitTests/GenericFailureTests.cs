using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjasoft.Results.UnitTests
{
    [TestFixture]
    internal sealed class GenericFailureTests
    {
        [Test]
        public void DefaultConstructor_IsSuccess_IsFalse()
        {
            var result = new Failure<FailureItem>();
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void DefaultConstructor_ErrorMessage_IsNull()
        {
            var result = new Failure<FailureItem>();
            Assert.That(result.ErrorMessage, Is.Null);
        }

        [Test]
        public void DefaultConstructor_Data_IsNull()
        {
            var result = new Failure<FailureItem>();
            Assert.That(result.Data, Is.Null);
        }

        [Test]
        public void MessageConstructor_IsSuccess_IsFalse()
        {
            var result = new Failure<FailureItem>("Any text");
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void MessageConstructor_ErrorMessage_IsNotNull()
        {
            var result = new Failure<FailureItem>("Any text");
            Assert.That(result.ErrorMessage, Is.EqualTo("Any text"));
        }

        [Test]
        public void MessageConstructor_Data_IsNull()
        {
            var result = new Failure<FailureItem>("Any text");
            Assert.That(result.Data, Is.Null);
        }

        [Test]
        public void ResultConstructorWithGenericFailure_IsSuccess_IsFalse()
        {
            var r = new Failure<OtherFailureItem>();
            var result = new Failure<FailureItem>(r);
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void ResultConstructorWithFailure_IsSuccess_IsFalse()
        {
            var r = new Failure();
            var result = new Failure<FailureItem>(r);
            Assert.That(result.IsSuccess, Is.False);
        }

        [Test]
        public void ResultConstructorWithFailure_ErrorMessage_IsErrorFromResult()
        {
            var r = new Failure("Some Error Message");
            var result = new Failure<FailureItem>(r);
            Assert.That(result.ErrorMessage, Is.EqualTo("Some Error Message"));
        }

        [Test]
        public void ResultConsturctorWithSuccess_()
        {
            var r = new Success();
            var ex = Assert.Throws<Exception>(() => new Failure<FailureItem>(r));
            Assert.That(ex.Message, Is.EqualTo("result type of Failure was expected"));
        }

        [Test]
        public void ResultConstructorWithGenericSuccess_()
        {
            var r = new Success<SuccessItem>(new SuccessItem());
            var ex = Assert.Throws<Exception>(() => new Failure<FailureItem>(r));
            Assert.That(ex.Message, Is.EqualTo("result type of Failure was expected"));
        }
    }

    public class FailureItem
    {
        public int Id { get; set; }
    }

    public class OtherFailureItem
    {
        public string Name { get; set; }
    }
}
