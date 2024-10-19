namespace Ninjasoft.Results
{
    public class Failure : Result
    {
        public Failure()
        {
            Success = false;
        }

        public Failure(string errorMessage)
        {
            Success = false;
            ErrorMessage = errorMessage;
        }
    }

    public class Failure<T> : Result<T>
    {
        public Failure()
        {
            Success = false;
        }

        public Failure(string errorMessage)
        {
            Success = false;
            ErrorMessage = errorMessage;
        }
    }
}
