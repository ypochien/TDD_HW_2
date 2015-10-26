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

        public int CalculateTotalAmount()
        {
            return Orders.Sum(item => item.Cost);
        }
    }
}