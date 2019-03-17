namespace Domain
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
            return new Result<T>(result, null);
        }

        public static Result Fail(string message)
        {
            return new Result(false, message);
        }

        public static Result<T> Fail<T>(string message)
        {
            return new Result<T>(default, message);
        }
    }

    public class Result<T> : Result
    {
        public T Value { get; }

        protected internal Result(T value, string error) : base(true, error)
        {
            Value = value;
        }
    } 
}
