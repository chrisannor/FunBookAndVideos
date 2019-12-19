namespace FunBookAndVideos.Core.Exceptions
{
    public class UserDoesNotExist : FunBookAndVideosException
    {
        public UserDoesNotExist() : base(ErrorCode.InvalidUser, "Customer does not exist")
        {
        }
    }
}
