using System.Collections.Generic;
using FunBookAndVideos.Core.Entitties;

namespace FunBookAndVideos.Core.Services
{
    public interface IPurchaseOrderService
    {
        string GeneratePurchaseOrderSlip(List<IProduct> products);
    }
}
