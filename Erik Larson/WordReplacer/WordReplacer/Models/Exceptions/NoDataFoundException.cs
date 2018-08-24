using System;

namespace WordReplacer.Models.Exceptions
{

    public class NoDataFoundException: Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoDataFoundException"/> class.
        /// </summary>
        public NoDataFoundException() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoDataFoundException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public NoDataFoundException(string message) : base(message) { }
    }
}
