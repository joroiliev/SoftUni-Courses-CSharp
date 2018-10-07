namespace SIS.HTTP.Exceptions
{
    using System;

    public class BadRequestException : Exception
    {
        private const string BadRequestErrorMessage = "The Request was malformed or contains unsupported elements.";

        public BadRequestException() : this(BadRequestErrorMessage)
        {
        }

        public BadRequestException(string message) : base(message)
        {
        }
    }
}
