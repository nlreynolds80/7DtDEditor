namespace Services
{
    public class Result
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public string Error { get; }

        protected Result(bool isSuccess, string error)
        {
            IsSuccess = isSuccess;
            Error = error;
        }

        public static Result Ok()
        {
            return new Result(true, null);
        }

        public static Result<T> Ok<T>(T result)
        {
            return new Result<T>(result);
        }

        public static Result Fail(string message)
        {
            return new Result(false, message);
        }
    }

    public class Result<T> : Result
    {
        public T Value { get; }

        protected internal Result(T value) : base(true, null)
        {
            Value = value;
        }
    } 
}
