using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingInfoDelegate
{
    public delegate void ShippingDelegate(string shippingZone, decimal fees);

    class ShippingInfo
    {
        public decimal feeCalculate(decimal productPrice, decimal shippingCost)
        {
            return productPrice + shippingCost;
        }
    }
}
