using System.Threading.Tasks;
using FunBookAndVideos.Core.Data.Repositories;
using FunBookAndVideos.Core.Entitties;

namespace FunBookAndVideos.Core.Rules
{
    public class MembershipRule : IRule
    {

        public readonly IRule _nextRule;
        private readonly IUserRepository _userRepository;

        public MembershipRule(IRule nextRule, IUserRepository userRepository)
        {
            _nextRule = nextRule;
            _userRepository = userRepository;
        }


        public async Task<bool> GetResultAsync(PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder.PurchaseOrderType == PurchaseOrderType.Membership)
            {
                _userRepository.AddMembership(purchaseOrder.CustomerId, purchaseOrder.Memberships);
            }
            return await _nextRule.GetResultAsync(purchaseOrder);
        }
    }


}
