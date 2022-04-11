namespace Lemonade.Stand.Application.Exceptions
{
    public class NotEnoughMoneyPaidException : Exception
    {
        public NotEnoughMoneyPaidException()
             : base() { }
        public NotEnoughMoneyPaidException(string message)
             : base() { }
        public NotEnoughMoneyPaidException(string message, Exception innerException)
             : base() { }
        public NotEnoughMoneyPaidException(string message, object key)
             : base() { }
    }
}