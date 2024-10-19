namespace Ninjasoft.Results
{
    public class Failure : IResult
    {
        public Failure()
        {
        }

        public Failure(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public Failure(IResult result)
        {
            var resultType = result.GetType();
            if (resultType.IsGenericType)
                resultType = resultType.BaseType;

            if(resultType != typeof(Failure))
                throw new Exception("result type of Failure was expected");

            ErrorMessage = result.ErrorMessage;
        }

        public bool IsSuccess => false;

        public string? ErrorMessage { get; }
    }

    public class Failure<T> : Failure, IResult<T>
    {
        public Failure() 
            : base()
        {
        }

        public Failure(string errorMessage) 
            : base(errorMessage)
        {
        }

        public Failure(IResult result)
            : base(result)
        {
        }

        public T? Data => default(T);
    }
}
