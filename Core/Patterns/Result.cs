using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Patterns
{
    public class Result<T>
    {
        public bool Status { get; private set; }
        public string Message { get; private set; }
        public T Data { get; private set; }

        /// <summary>
        /// Pattern to communicate with handlers
        /// </summary>
        /// <param name="status">Is Success When Executed</param>
        /// <param name="message">Message tohandlers</param>
        /// <param name="data">Dto to handlers</param>
        public Result(bool status, string message, T data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
        /// <summary>
        /// Pattern to communicate with handlers
        /// </summary>
        /// <param name="status">Is Success When Executed</param>
        /// <param name="message">Message tohandlers</param>
        public Result(bool status, string message)
        {
            Status = status;
            Message = message;
        }

        public static implicit operator bool(Result<T> result)
        {
            return result.Status;
        }
    }
}
