using System;
using System.Collections.Generic;
using System.Text;
using FunBookAndVideos.Core.Entitties;
using FunBookAndVideos.Core.Exceptions;

namespace FunBookAndVideos.Core.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        public string GeneratePurchaseOrderSlip(List<IProduct> products)
        {
            if(products.Count <= 0) throw new ProductListEmpty();
            var purchaseOrder = new StringBuilder("Fun Book & Video Purchase Order");
            purchaseOrder.AppendLine($"Date: {DateTime.UtcNow.ToShortDateString()}");
            purchaseOrder.AppendLine("");
            foreach (var product in products)
            {
                purchaseOrder.AppendLine("--------------------------");
                purchaseOrder.AppendLine($"Product: {product.Name}");
                purchaseOrder.AppendLine($"Price: {product.Name}");
                purchaseOrder.AppendLine("--------------------------");
            }

            return purchaseOrder.ToString();
        }
    }
}
