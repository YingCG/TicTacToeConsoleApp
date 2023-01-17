using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingInfoDelegate
{
    public delegate void ShippingDelegate();

    class ShippingInfo
    {
        public string zone;
        protected decimal _productPrice;
        public decimal productPrice {
            get { return _productPrice; }
            set { _productPrice = value; }
        }
        public virtual decimal FeeCalculate(string zone, decimal productPrice)
        {
            return productPrice;
        }
    }

    class Zone1 : ShippingInfo
    {
        public override decimal FeeCalculate(string zone, decimal productPrice)
        {
            decimal shippingCost = productPrice * 1.25M;
            return shippingCost;
        }
    }

    class Zone2 : ShippingInfo
    {
        public override decimal FeeCalculate(string zone, decimal productPrice)
        {
            decimal shippingCost = (productPrice * 1.12M) + 25M;
            return shippingCost;
        }
    }

    class Zone3 : ShippingInfo
    {
        public override decimal FeeCalculate(string zone, decimal productPrice)
        {
            decimal shippingCost = productPrice * 1.08M;
            return shippingCost;
        }
    }

    class Zone4 : ShippingInfo
    {
        public override decimal FeeCalculate(string zone, decimal productPrice)
        {
            decimal shippingCost = (productPrice * 1.04M) + 25M;
            return shippingCost;
        }
    }
}
