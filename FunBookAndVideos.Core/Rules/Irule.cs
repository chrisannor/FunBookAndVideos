﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FunBookAndVideos.Core.Entitties;

namespace FunBookAndVideos.Core.Rules
{
    public interface IRule
    {
        Task<bool> GetResultAsync(PurchaseOrder purchaseOrder);
    }


}
