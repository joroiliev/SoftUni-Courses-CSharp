namespace SIS.HTTP.Exceptions
{
    using System;

    public class InternalServerErrorException : Exception
    {
        private const string InternalServerErrorMessage = "The Server has encountered an error.";

        public InternalServerErrorException() : this(InternalServerErrorMessage)
        {
        }

        public InternalServerErrorException(string message) : base(message)
        {
        }
    }
}
