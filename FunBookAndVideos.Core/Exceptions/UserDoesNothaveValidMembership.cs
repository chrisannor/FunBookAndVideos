using System.Collections.Generic;
using System.Text;

namespace FunBookAndVideos.Core.Exceptions
{
    public class UserDoesNothaveValidMembership : FunBookAndVideosException
    {
        public UserDoesNothaveValidMembership() : base(ErrorCode.NoValidMembership, "Customer does not have any valid membership")
        {
        }
    }
}
