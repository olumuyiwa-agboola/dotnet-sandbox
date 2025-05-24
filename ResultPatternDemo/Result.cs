
namespace ResultPatternDemo
{
    public class Result
    {
        #region Private constructors
        public Result()
        {
            Error = null;
            IsSuccessful = true;
        }

        private Result(ErrorType errorType, string errorMessage)
        {
            IsSuccessful = false;
            Error = new Error(errorType, errorMessage);
        }
        #endregion

        #region Public properties
        public Error? Error { get; }

        public bool? IsSuccessful { get; }
        #endregion

        public static Result Success() => new Result();
        public static Result Failure(ErrorType errorType, string errorMessage) => new Result(errorType, errorMessage);
    }
}