namespace Lemonade.Stand.Application.Exceptions
{
    public class NotEnoughFruitsException : Exception
    {
        public NotEnoughFruitsException() : base() { }
        public NotEnoughFruitsException(string message) : base() { }
        public NotEnoughFruitsException(string message, Exception innerException) : base() { }
        public NotEnoughFruitsException(string message, object key) : base() { }
    }
}