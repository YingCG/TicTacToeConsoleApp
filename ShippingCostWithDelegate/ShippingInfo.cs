using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingCostWithDelegate
{
    public delegate void shippingFeesDelegate(string shippingZone, decimal price);
    abstract class ShippingInfo
    {
        public bool isHighRisk;
        public void calculateShippingFees(string shippingZone, decimal price)
        {

        }
    }
}
