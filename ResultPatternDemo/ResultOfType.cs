
namespace ResultPatternDemo
{
    public class ResultOfType<T>
    {
        #region Private constructors
        public ResultOfType(T value)
        {
            Error = null;
            Value = value;
            IsSuccessful = true;
        }

        private ResultOfType(ErrorType errorType, string errorMessage)
        {
            Value = default;
            IsSuccessful = false;
            Error = new Error(errorType, errorMessage);
        }
        #endregion

        #region Public properties
        public T? Value { get; }

        public Error? Error { get; }

        public bool? IsSuccessful { get; }
        #endregion

        public static ResultOfType<T> Success(T value) => new ResultOfType<T>(value);
        public static ResultOfType<T> Failure(ErrorType errorType, string errorMessage) => new ResultOfType<T>(errorType, errorMessage);
    }
}