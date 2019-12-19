using System.Threading.Tasks;
using FunBookAndVideos.Core.Entitties;
using FunBookAndVideos.Core.Services;

namespace FunBookAndVideos.Core.Rules
{
    public class FirstAidRule : IRule
    {
        public IRule _nextRule;
        private readonly IPurchaseOrderService _purchaseOrderService;

        public FirstAidRule(IRule nextRule, IPurchaseOrderService purchaseOrderService)
        {
            _nextRule = nextRule;
            _purchaseOrderService = purchaseOrderService;
        }

        public async Task<bool> GetResultAsync(PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder.ProductLines.Find(x => x.Name == "Comprehensive First Aid Training") != null)
            {
                purchaseOrder.ProductLines.Add(new Video());
            }
            return await _nextRule.GetResultAsync(purchaseOrder);
        }
    }


}
