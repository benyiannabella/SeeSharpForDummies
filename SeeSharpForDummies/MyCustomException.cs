using System;

namespace SeeSharpForDummies
{
    public class MyCustomException : Exception
    {
        public MyCustomException()  : base()
        {

        } 
        public MyCustomException(string message)  : base(message)
        {

        }
    }
}
