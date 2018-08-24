using System;

namespace WordReplacer.Models.Exceptions
{

    public class XMLContentException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XMLContentException"/> class.
        /// </summary>
        public XMLContentException() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="XMLContentException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public XMLContentException(string message) : base(message) { }
      
    }
}
