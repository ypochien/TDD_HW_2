using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        private List<BOOK> Orders = new List<BOOK> { };
        public void PickUp(BOOK book)
        {
            Orders.Add(book);
        }

        private double CalculateDiscount()
        {
            double DiscountAmount = Orders.Sum(item => item.Cost);
            switch (Orders.Count) {
                case 1:
                    DiscountAmount *= 1.0;
                        break;
                case 2:
                    DiscountAmount *= 0.95;
                    break;
                case 3:
                    DiscountAmount *= 0.9;
                    break;
            }
            return DiscountAmount;
        }

        public double CalculateTotalAmount()
        {


            return CalculateDiscount();

        }
    }
}