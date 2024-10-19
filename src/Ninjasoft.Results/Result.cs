namespace Ninjasoft.Results
{
    public abstract class Result
    {
        public bool Success { get; protected set; }

        public string? ErrorMessage { get; protected set; }
    }

    public abstract class Result<T>
    {
        public bool Success { get; protected set; }

        public string? ErrorMessage { get; protected set; }

        public T? Data { get; protected set; }
    }
}
