namespace Lemonade.Stand.Application.Exceptions
{
    public class WrongFruitException : Exception
    {
        public WrongFruitException()
             : base() { }

        public WrongFruitException(string message)
             : base() { }

        public WrongFruitException(string message, Exception innerException)
             : base() { }

        public WrongFruitException(string name, object key)
             : base() { }
    }
}