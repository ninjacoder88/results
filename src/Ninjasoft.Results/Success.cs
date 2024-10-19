namespace Ninjasoft.Results
{
    public class Success : Result
    {
        public Success()
        {
            Success = true;
        }
    }

    public class Success<T> : Result<T>
    {
        public Success()
        {
            Success = true;
        }

        public Success(T? data)
        {
            Data = data;
        }
    }
}
