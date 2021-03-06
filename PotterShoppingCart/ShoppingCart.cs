﻿using System;
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

        private double CalculateDiscount(List<BOOK> _books)
        {
            double DiscountAmount = _books.Sum(item => item.Cost);
            switch (_books.Count) {
                case 1:
                    DiscountAmount *= 1.0;
                        break;
                case 2:
                    DiscountAmount *= 0.95;
                    break;
                case 3:
                    DiscountAmount *= 0.9;
                    break;
                case 4:
                    DiscountAmount *= 0.8;
                    break;
                case 5:
                    DiscountAmount *= 0.75;
                    break;
            }
            return DiscountAmount;
        }

        public double CalculateTotalAmount()
        {
            List<BOOK> books = Orders;
            double amount = 0.0;
            while (books.Count > 0)
            {
                var distinctBooks = from book in books
                                    group book by new { book.Name, book.Cost } into g
                                    select new BOOK { Name = g.Key.Name, Cost = g.Key.Cost };
                amount += CalculateDiscount(distinctBooks.ToList());

                foreach (BOOK b in distinctBooks)
                {
                    books.Remove(b);
                }
            }
            return amount;
        }
    }
}