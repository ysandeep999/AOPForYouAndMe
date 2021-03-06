﻿using System.Threading;
using AOPForYouAndMe.Models.Business;

namespace AOPForYouAndMe.Models
{
    // 1 - no cache
    public class SlowLegacyService : ISlowLegacyService
    {
        public CarPrice GetPrice(CarPricingForm form)
        {
            Thread.Sleep(5000);
            return CarPrice.Generate();
        }
    }
}