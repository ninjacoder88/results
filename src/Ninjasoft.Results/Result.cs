namespace Ninjasoft.Results
{
    public interface IResult
    {
        public bool IsSuccess { get; }

        public string? ErrorMessage { get; }
    }

    public interface IResult<T> : IResult
    {
        public T? Data { get; }
    }
}
