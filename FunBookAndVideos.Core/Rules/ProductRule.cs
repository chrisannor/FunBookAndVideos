using System.Threading.Tasks;
using FunBookAndVideos.Core.Entitties;
using FunBookAndVideos.Core.Services;

namespace FunBookAndVideos.Core.Rules
{
    public class ProductRule : IRule
    {

        public readonly IRule _nextRule;
        private readonly IPurchaseOrderService _purchaseOrderService;
        private readonly IPrinterService _printerService;

        public ProductRule(IRule nextRule, IPurchaseOrderService purchaseOrderService, IPrinterService printerService)
        {
            _nextRule = nextRule;
            _purchaseOrderService = purchaseOrderService;
            _printerService = printerService;
        }


        public async Task<bool> GetResultAsync(PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder.PurchaseOrderType == PurchaseOrderType.Product)
            {
                var shippingSlip = _purchaseOrderService.GeneratePurchaseOrderSlip(purchaseOrder.ProductLines);
                _printerService.PrintText(shippingSlip);
            }
            return await _nextRule.GetResultAsync(purchaseOrder);
        }
    }


}
