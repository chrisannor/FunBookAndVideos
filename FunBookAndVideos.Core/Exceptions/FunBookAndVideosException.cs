using System;

namespace FunBookAndVideos.Core.Exceptions
{
    public class FunBookAndVideosException : Exception
    {
        public readonly ErrorCode ErrorCode;

        public FunBookAndVideosException(ErrorCode errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
