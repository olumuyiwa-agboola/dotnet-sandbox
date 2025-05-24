namespace ResultPatternDemo
{
    public class Error(ErrorType type, string message)
    {
        public string Message { get; init; } = message;    
        public ErrorType Type { get; init; } = type;
    }

    public enum ErrorType
    {
        InvalidInput,
        UnprocessableEntity
    }
}