namespace Ninjasoft.Results
{
    public class Success : IResult
    {
        public bool IsSuccess => true;

        public string? ErrorMessage => null;
    }

    public class Success<T> : Success, IResult<T>
    {
        public Success(T? data)
        {
            Data = data;
        }

        public T? Data { get; }
    }
}
